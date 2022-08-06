using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomPos : MonoBehaviour
{
    public int[] myArray = new int[]{ -4, -2, 0, 2, 4 };
    //public int[] myIndex;

    void Start()
    {
        //var MyArray = new Array("HiggyB", "bedalowe", "unknown");
        var MyIndex = Random.Range(0, myArray.Length);
        

        for (int x = 0; x < 10; x++)
        {
            MyIndex = Random.Range(0, myArray.Length);
            Debug.Log(myArray[MyIndex]);
        }
    }
    


        
 

    
}
