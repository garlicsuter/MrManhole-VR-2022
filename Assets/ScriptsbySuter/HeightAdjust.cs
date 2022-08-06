using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightAdjust : MonoBehaviour
{
    public GameObject cam;
    public Vector3 dist = new Vector3(0, 0.5f, 0);

   public void GoUp()
    {
        cam.transform.position += dist;
        Debug.Log("Up");
    }

    public void GoDown()
    {
        cam.transform.position -= dist;
        Debug.Log("Up");
    }
}
