using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowOffset : MonoBehaviour
{
    public GameObject theS770;
    public ChildSpeedPlateToS770 otherScript;
    
    public Vector3 newOffset;
    public bool FollowMe = false;
    // Start is called before the first frame update
    void Start()
    {
        ChildSpeedPlateToS770 otherScript = GameObject.Find("S770_plus_SS_mount_05_Zfwd").GetComponent<ChildSpeedPlateToS770>();
    }

    public void FollowMeTrue()
    {
        newOffset = otherScript.theOffset;
        FollowMe = true;
        Debug.Log("FollowMe = " + FollowMe + " + new Offset = " + newOffset);
    }

    // Update is called once per frame
    void Update()
    {
        if(FollowMe == true)
        {
            this.transform.position = theS770.transform.position - newOffset;
        }
    }
}
