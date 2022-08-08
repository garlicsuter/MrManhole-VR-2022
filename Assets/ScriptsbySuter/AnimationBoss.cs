using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBoss : MonoBehaviour
{
    public GameObject theSpeedplate;
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public ParticleSystem CorrectParticles;

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
        Q2.SetActive(true);
    }

    IEnumerator Q1DelayCoroutine()
    {
        //Print the time of when the function is first called.
        //Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(4);
        Debug.Log("Why am I waiting 4 seconds?");
        
        //After we have waited 5 seconds print the time again.
        //Debug.Log("Finished Coroutine at timestamp : " + Time.time);
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
