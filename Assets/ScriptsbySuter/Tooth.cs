using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableGravity()
    {
        this.GetComponent<Rigidbody>().useGravity = true;
        Debug.Log("Gravity On");
    }
}
