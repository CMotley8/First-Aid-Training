using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig")
        {
            Application.Quit();
        }
    }
}