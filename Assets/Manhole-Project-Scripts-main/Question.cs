using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    public GameObject[] buttonAnswers;
    public Vector3[] answerLocalPosition;
    public int maxQuestionPoints = 4;
    public int currentQuestionPoints = 4;

    void Start()
    {
        ShuffleAnswers();
        currentQuestionPoints = maxQuestionPoints;
    }

    void ShuffleAnswers()
    {
        //if different directions are given, ignore these positions
        if (answerLocalPosition.Length != buttonAnswers.Length && buttonAnswers.Length == 4)
        {
            //default four positions for answers
            answerLocalPosition = new[] { new Vector3(-29.5f, -6.5f, 0f), new Vector3(25.5f, -6.5f, 0f), new Vector3(-29.5f, -20.5f, 0f), new Vector3(25.5f, -20.5f, 0f) };
        }

        for (int i = 0; i < buttonAnswers.Length; i++)
        {
            //grabs random answer for shuffling
            int randomNumber = Random.Range(0, buttonAnswers.Length - 1);

            if (randomNumber != i)
            {
                //shuffles the two answers around
                GameObject placeHolder = buttonAnswers[i];
                buttonAnswers[i] = buttonAnswers[randomNumber];
                buttonAnswers[randomNumber] = placeHolder;
            }
        }

        //after the order, put everything in place
        for (int i = 0; i < 4; i++)
        {
            buttonAnswers[i].transform.localPosition = answerLocalPosition[i];
        }
    }

    public void Restart()
    {
        ShuffleAnswers();
        currentQuestionPoints = maxQuestionPoints;
    }

    public void UpdateQuestionPoints()
    {
        if (currentQuestionPoints != 0)
        {
            currentQuestionPoints--;
        }
    }
}
