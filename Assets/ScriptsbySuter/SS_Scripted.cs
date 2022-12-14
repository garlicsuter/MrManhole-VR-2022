using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS_Scripted : MonoBehaviour
{
    //public GameObject Mounty;
    //public GameObject Donut;
    public GameObject oldRing;
    public GameObject streetDonutHole;
    //public GameObject oldStreet;
    //public GameObject speedplateDummy;
    public GameObject speedplateOriginal;
    //public GameObject lidRingOriginal;
    public GameObject roadKerf;
    public GameObject road_1;
    //private Vector3 offset;


    //void Start()
    //{
    //    offset = transform.position - Mounty.transform.position;
    //}

    //void LateUpdate()
    //{
    //    transform.position = Mounty.transform.position + offset;
    //}

    public void KerfOn()
    {
        roadKerf.SetActive(true);
        road_1.SetActive(false);
    }

    public void DonutStart()
    {
        roadKerf.SetActive(false);
        streetDonutHole.SetActive(true);
        //oldStreet.SetActive(false);
        speedplateOriginal.SetActive(false);
        oldRing.SetActive(false);
    }

}