using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoring : MonoBehaviour
{
    public GameObject[] totalQuestions;
    public GameObject[] chosenQuestions;

    private int correctCounter;
    private int[] placementStorage;

    void Start()
    {
        ShuffleQuestions();
    }

    void ShuffleQuestions()
    {
        for (int i = 0; i < chosenQuestions.Length; i++)
        {
            //grabs random question from total
            int randomNumber = Random.Range(0, totalQuestions.Length - 1);

            if (totalQuestions[randomNumber] != null)
            {
                //sets that question as chosen
                chosenQuestions[i] = totalQuestions[randomNumber];

                //remember the location to set back to later
                placementStorage[i] = randomNumber;

                //sets null to not grab the same question again
                totalQuestions[randomNumber] = null;
            }
            else
            {
                //reruns statement
                i--;
            }
        }

        //give chosen questions to animation boss
        GetComponent<AnimationBoss>().Q1 = chosenQuestions[0];
        GetComponent<AnimationBoss>().Q2 = chosenQuestions[1];
        GetComponent<AnimationBoss>().Q3 = chosenQuestions[2];
        GetComponent<AnimationBoss>().Q4 = chosenQuestions[3];
        /// GetComponent<AnimationBoss>().Q5 = chosenQuestions[4];

        //give chosen questions to reset
        GetComponent<Reset>().Q1 = chosenQuestions[0];
        GetComponent<Reset>().Q2 = chosenQuestions[1];
        GetComponent<Reset>().Q3 = chosenQuestions[2];
        GetComponent<Reset>().Q4 = chosenQuestions[3];
        /// GetComponent<Reset>().Q5 = chosenQuestions[4];

        //starts score text
        ScoringTime();
    }

    public void Restart()
    {
        for (int i = 0; i < chosenQuestions.Length; i++)
        {
            //puts question back in its original spot
            totalQuestions[placementStorage[i]] = chosenQuestions[i];
        }

        //randomizes questions again
        ShuffleQuestions();

        correctCounter = 0;
    }

    public void CorrectAnswer()
    {
        //counts correct answers and starts next question
        GameObject gm = GameObject.Find("GameManager");

        correctCounter++;

        if (correctCounter == 1)
        {
            //start questions 2
            GetComponent<AnimationBoss>().Q1Delay();
            GetComponent<AnimationBoss>().Q1Correct();
        }
        else if (correctCounter == 2)
        {
            //start questions 3
            GetComponent<AnimationBoss>().Q2Delay();
            GetComponent<AnimationBoss>().Q2Correct();
        }
        else if (correctCounter == 3)
        {
            //start questions 4
            /// GetComponent<AnimationBoss>().Q3Delay();
            /// GetComponent<AnimationBoss>().Q3Correct();
        }
        else if (correctCounter == 4)
        {
            //start questions 5
            /// GetComponent<AnimationBoss>().Q4Delay();
            /// GetComponent<AnimationBoss>().Q4Correct();
        }
    }

    public void IncorrectAnswer()
    {
        //subtracts points and updates the score
        chosenQuestions[correctCounter].GetComponent<Question>().UpdateQuestionPoints();
        ScoringTime();
    }

    public void ScoringTime()
    {
        if (chosenQuestions.Length != 0)
        {
            //score one
            TMP_Text Q1ScoreText = GameObject.Find("Q1 - Score").GetComponent<TextMeshProUGUI>();
            int Q1Score = chosenQuestions[0].GetComponent<Question>().currentQuestionPoints;
            Q1ScoreText.text = chosenQuestions[0].name + ": " + Q1Score;

            //score two
            TMP_Text Q2ScoreText = GameObject.Find("Q2 - Score").GetComponent<TextMeshProUGUI>();
            int Q2Score = chosenQuestions[1].GetComponent<Question>().currentQuestionPoints;
            Q2ScoreText.text = chosenQuestions[1].name + ": " + Q2Score;

            //score three
            TMP_Text Q3ScoreText = GameObject.Find("Q3 - Score").GetComponent<TextMeshProUGUI>();
            int Q3Score = chosenQuestions[2].GetComponent<Question>().currentQuestionPoints;
            Q3ScoreText.text = chosenQuestions[2].name + ": " + Q3Score;

            //score four
            TMP_Text Q4ScoreText = GameObject.Find("Q4 - Score").GetComponent<TextMeshProUGUI>();
            int Q4Score = chosenQuestions[3].GetComponent<Question>().currentQuestionPoints;
            Q4ScoreText.text = chosenQuestions[3].name + ": " + Q4Score;

            //score five
            TMP_Text Q5ScoreText = GameObject.Find("Q5 - Score").GetComponent<TextMeshProUGUI>();
            /// int Q5Score = chosenQuestions[4].GetComponent<Question>().currentQuestionPoints;
            /// Q5ScoreText.text = chosenQuestions[4].name + ": " + Q5Score;

            //score total
            TMP_Text totalScoreText = GameObject.Find("Total Score").GetComponent<TextMeshProUGUI>();
            int totalScore = Q1Score + Q2Score + Q3Score + Q4Score;
            /// add " + Q5Score" to totalScore equation
            totalScoreText.text = "Total Score: " + totalScore;
        }
    }
}
