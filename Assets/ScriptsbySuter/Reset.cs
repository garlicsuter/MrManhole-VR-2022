using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject startButton;
    public GameObject manholeCover;
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public GameObject Q5;

    // Start is called before the first frame update
    void Start()
    {
        startButton.SetActive(true);
        manholeCover.SetActive(true);
        Q1.SetActive(false);
        Q2.SetActive(false);
        Q3.SetActive(false);
        Q4.SetActive(false);
        Q5.SetActive(false);
    }

    
}
