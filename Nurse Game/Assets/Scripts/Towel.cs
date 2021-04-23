using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towel : MonoBehaviour
{
    public Material wetMat;

    void OnTriggerEnter(Collider col)
    {
       if(col.gameObject.tag == "Water")
        {
            GetComponent<Renderer>().material = wetMat;
            gameObject.tag = "Wet Towel";
        }
    }
}