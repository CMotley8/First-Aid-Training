using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    [Tooltip("This is the GameObject for the initial buttons (Main Menu/Replay/Select Treatment).")]
    public GameObject initialButtons;
    [Tooltip("This is the GameObject for the buttons that appear after you press the Select Treatment button.")]
    public GameObject treatmentTypeButtons;

    void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig")
        {
            treatmentTypeButtons.SetActive(false);
            initialButtons.SetActive(true);
        }
    }
}