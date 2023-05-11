using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public int scoreValue = 0;
    public bool runTimer = true;
    public int timerInt;


    public void Start()
    {
        StartCoroutine(time());
    }
    IEnumerator time()
    {
        while (runTimer)
        {
            timeCount();
            yield return new WaitForSeconds(1);
        }
    }
    void timeCount()
    {
        timerInt += 1;
        timerText.text = "Time: " + timerInt.ToString();
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + scoreValue.ToString();
        Debug.Log("Updated Score: " + scoreValue);
    }

    public void CorrectAddTen()
    {
        scoreValue += 10;
        UpdateScore();
    }

    public void WrongMinusTen()
    {
        scoreValue -= 10;
        UpdateScore();
    }

    public void StopTimer()
    {
        runTimer = false;
    }

}
