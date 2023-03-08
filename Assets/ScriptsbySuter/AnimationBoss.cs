using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBoss : MonoBehaviour
{
    public GameObject theSpeedplate;
    public GameObject S770;
    public GameObject theCover;
    public GameObject StartButton;
    public GameObject RoadFULL;
    public GameObject RoadKerf;
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public GameObject Q5;
    public ParticleSystem CorrectParticles;
    public ScoreKeeper scoreKeeper;

    private void Awake()
    {
        scoreKeeper = GetComponent<ScoreKeeper>();
    }
    public void ChildSpeedPlatetoS770()
    {
        theSpeedplate.transform.parent = S770.transform;
    }
    
    public void CoverRemove()
    {
        theCover.GetComponent<Animator>().Play("Cover-Remove");
        Debug.Log("Cover made cover remove!");
        StartButton.SetActive(false);
        StartCoroutine(waiter());
    }

    public void SwitchRoads()
    {
        RoadFULL.SetActive(false);
        RoadKerf.SetActive(true);
    }
    IEnumerator waiter()
    {
        //Wait for 1 second
        yield return new WaitForSeconds(1.5f);

        //Activate Q1
        Q1.SetActive(true);
    }

    public void Q1Delay()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(Q1DelayCoroutine());
    }

    public void Q1Correct()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(Q1CorrectRoutine());
        scoreKeeper.CorrectAddTen();
    }

    IEnumerator Q1CorrectRoutine()
    {
        ShootCannon();
        yield return new WaitForSeconds(1);
        Q1.SetActive(false);
    }

    IEnumerator Q1DelayCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2);
        Q2.SetActive(true);
        Debug.Log("Why am I waiting 2 seconds?");
    }

    public void Q2Correct()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(Q2CorrectRoutine());
        scoreKeeper.CorrectAddTen();
    }

    IEnumerator Q2CorrectRoutine()
    {
        ShootCannon();
        yield return new WaitForSeconds(1);
        Q2.SetActive(false);
    }

    public void Q2Delay()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(Q2DelayCoroutine());
    }

    IEnumerator Q2DelayCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(10);
        Q3.SetActive(true);
        Debug.Log("Waited 10 seconds before Q3 Activated in AnimationBoss");
    }

    public void Q3Correct()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(Q3CorrectRoutine());
        scoreKeeper.CorrectAddTen();
    }

    IEnumerator Q3CorrectRoutine()
    {
        ShootCannon();
        yield return new WaitForSeconds(1);
        Q3.SetActive(false);
    }

    public void Q3Delay()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(Q3DelayCoroutine());
    }

    IEnumerator Q3DelayCoroutine()
    {
        //yield on a new YieldInstruction that waits for 4 seconds.
        yield return new WaitForSeconds(4);
        Q4.SetActive(true);
        Debug.Log("Waiting 4 seconds to wait for animation to finish before showing next Q");
    }

    /////////////////Begin Q4
    public void Q4Correct()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(Q3CorrectRoutine());
        scoreKeeper.CorrectAddTen();
    }

    IEnumerator Q4CorrectRoutine()
    {
        ShootCannon();
        yield return new WaitForSeconds(1);
        Q4.SetActive(false);
    }

    public void Q4Delay()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(Q4DelayCoroutine());
    }

    IEnumerator Q4DelayCoroutine()
    {
        //yield on a new YieldInstruction that waits for 4 seconds.
        yield return new WaitForSeconds(4);
        Q5.SetActive(true);
        Debug.Log("Waiting for fly-in of white ring,topper,lid before showing next Q");
    }
    /////////////////End Q4
    

    public void ShootCannon()
    {
        CorrectParticles.Play();
    }
}
