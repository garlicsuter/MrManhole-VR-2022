using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildSpeedPlateToS770 : MonoBehaviour
{
    public GameObject S770;
    public GameObject theSpeedplate;
    public Vector3 theOffset;
    public FollowOffset otherScript;

    public void Start()
    {
        otherScript = GameObject.Find("SpeedParent").GetComponent<FollowOffset>();
    }
    public void RunBoth()
    {
        GetOffset();
        ChildSpeedPlatetoS770();
        otherScript.FollowMeTrue();
        
    }
    public void GetOffset()
    {
        theOffset = theSpeedplate.transform.position - S770.transform.position;
    }
    public void ChildSpeedPlatetoS770()
    {
        Debug.Log("Offset: " + theOffset);
        theSpeedplate.transform.parent = S770.transform;
        theSpeedplate.transform.position = S770.transform.position;
    }

}
