using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBoss : MonoBehaviour
{
    public GameObject theSpeedplate;
    
    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Keypad1))
    //    {
    //        //theSpeedplate.GetComponent<Animator>().Play("1_PinsOut");
    //        Debug.Log("1 pressed");
    //    }

    //    if (Input.GetKeyDown(KeyCode.Keypad2))
    //    {
    //        theSpeedplate.GetComponent<Animator>().Play("2_LeftRightHalvesExpand");
    //    }
    //}
    
    

    public void Play0SPMoveIn()
    {
        theSpeedplate.GetComponent<Animator>().Play("MoveSpeedplateIn1");
        Debug.Log("MoveSpeedplateIn1 moved in");
    }

    public void Play1Pins()
    {
        theSpeedplate.GetComponent<Animator>().Play("1_PinsOut");
        Debug.Log("1 Pins Out");
    }

    public void Play2Expand()
    {
        theSpeedplate.GetComponent<Animator>().Play("2_LeftRightHalvesExpand");
        Debug.Log("2 expanded");
    }

    public void Play3PinsIn()
    {
        theSpeedplate.GetComponent<Animator>().Play("3_PinsIn");
        Debug.Log("3 Pins In");
    }

    public void Play4CircleSpin()
    {
        theSpeedplate.GetComponent<Animator>().Play("4_SpinCircleLock");
        Debug.Log("4 Sping Circle");
    }

    public void Play5HandleRelease()
    {
        theSpeedplate.GetComponent<Animator>().Play("5_HandleLockRelease");
        Debug.Log("5 Lock Release");
    }
}
