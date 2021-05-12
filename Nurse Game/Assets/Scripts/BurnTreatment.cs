﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BurnTreatment : Treatment
{
    public bool[] step = new bool[3];
    public GameObject menuButtons;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Wet Towel" && !step[1] && !step[2])
        {
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed)
            {
                step[0] = true;
                col.gameObject.SetActive(false);
            }
        }
        if(col.gameObject.tag == "Sterile Patch" && step[0] && !step[2])
        {
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed)
            {
                step[1] = true;
                col.gameObject.SetActive(false);
            }
        }
        if (col.gameObject.tag == "Gauze" && step[0] && step[1])
        {
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed)
            {
                step[2] = true;
                col.gameObject.SetActive(false);
            }
            Completed();
        }
    }

    public override void Completed()
    {
        // Placeholder; when the checklist is implemented there can be a big checkmark on the checklist.
        Debug.Log("The patient's burn as been treated!");
        
        /*
         *      Can  replace the treatment instructions and add three UI buttons; one to replay the scene, go to 
         *       main menu (would need to be created), and to go to the next treatment type (scene).
         *       
         *      Another option would be to make physical buttons like the play/next/previous buttons for the video player, instead of having UI buttons.
         *      The physical buttons would need to be somewhere near the player, such as on the table. If the buttons are on the table then the treatment
         *       instructions can be changed so that it is informing the player they have completed the treatment and needs to press one of the buttons on the table.
         */ 
        // Makes the menu buttons appear
        menuButtons.SetActive(true);
    }
}