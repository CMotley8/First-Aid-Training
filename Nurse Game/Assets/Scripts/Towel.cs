using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towel : MonoBehaviour
{

    public Material mat;
    void OnTriggerEnter(Collider col)
    {
       Debug.Log(col);
       if(col.gameObject.tag == "Water")
        {
         GetComponent<Renderer>().material = mat;
        }
    }
}
