using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS_SpeedplateHider : MonoBehaviour
{
    public GameObject speedPlateToHide;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideSpeedplate()
    {
        speedPlateToHide.SetActive(false);
        Debug.Log("Hid Speedplate");
    }
}
