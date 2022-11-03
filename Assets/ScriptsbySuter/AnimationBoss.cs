using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBoss : MonoBehaviour
{
    public GameObject theSpeedplate;
    public GameObject theCover;
    public GameObject StartButton;
    public GameObject RoadFULL;
    public GameObject RoadKerf;
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public ParticleSystem CorrectParticles;

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
        yield return new WaitForSeconds(4);
        Q3.SetActive(true);
        Debug.Log("Why am I waiting 4 seconds? To wait for animation to finish before showing next Q");
    }

    public void ShootCannon()
    {
        CorrectParticles.Play();
    }


    //END


    //public void Play0SPMoveIn()
    //{
    //    theSpeedplate.GetComponent<Animator>().Play("00_speedplate_movein_01");
    //    Debug.Log("Speedplate globaly moved in");
    //}

    //public void Play1Pins()
    //{
    //    theSpeedplate.GetComponent<Animator>().Play("1_PinsOut");
    //    Debug.Log("1 Pins Out");
    //}

    //public void Play2Expand()
    //{
    //    theSpeedplate.GetComponent<Animator>().Play("2_LeftRightHalvesExpand");
    //    Debug.Log("2 expanded");
    //}

    //public void Play3PinsIn()
    //{
    //    theSpeedplate.GetComponent<Animator>().Play("3_PinsIn");
    //    Debug.Log("3 Pins In");
    //}

    //public void Play4CircleSpin()
    //{
    //    theSpeedplate.GetComponent<Animator>().Play("4_SpinCircleLock");
    //    Debug.Log("4 Sping Circle");
    //}

    //public void Play5HandleRelease()
    //{
    //    theSpeedplate.GetComponent<Animator>().Play("5_HandleLockRelease");
    //    Debug.Log("5 Lock Release");
    //}
}
