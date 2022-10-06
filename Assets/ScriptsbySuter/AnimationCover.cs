using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCover : MonoBehaviour
{
    public GameObject theCover;
    public GameObject Q1;
    public GameObject StartButton;

    public void CoverRemove()
    {
        theCover.GetComponent<Animator>().Play("Cover-Remove");
        Debug.Log("Cover made cover remove!");
        StartButton.SetActive(false);
        StartCoroutine(waiter());    
    }


    IEnumerator waiter()
    {
        //Wait for 1 second
        yield return new WaitForSeconds(1.5f);

        //Activate Q1
        Q1.SetActive(true);
    }
}
