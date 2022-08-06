using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfettiFX : MonoBehaviour
{
    public GameObject Confetti;
    // Start is called before the first frame update
    public void Click()
    {
        GameObject ob = Instantiate(Confetti);
        Destroy(ob, 4.0f);
    }
}
