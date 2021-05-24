using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnTreatment : Treatment
{
    [Tooltip("This is the number of steps the treatment has.")]
    public bool[] step = new bool[3];
    [Tooltip("This is the GameObject for Menu buttons.")]
    public GameObject menuButtons;
    [Tooltip("This is the GameObject for the hydrogel dressing childed to the patient.")]
    public GameObject hydroGelDressing;
    [Tooltip ("This is the GameObject for the gauze childed to the patient.")]
    public GameObject fakeGauze;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Wet Towel" && !step[1] && !step[2])
        {
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed)
            {
                step[0] = true;
            }
        }
        if(col.gameObject.tag == "Sterile Dressing" && step[0] && !step[2])
        {
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed)
            {
                step[1] = true;
                hydroGelDressing.SetActive(true);
                col.gameObject.SetActive(false);
            }
        }
        if (col.gameObject.tag == "Gauze" && step[0] && step[1])
        {
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed)
            {
                step[2] = true;
                fakeGauze.SetActive(true);
                hydroGelDressing.SetActive(false);
                col.gameObject.SetActive(false);
            }
            Completed();
        }
    }

    public override void Completed()
    {
        /*
         * Change the step instructions to tell the player they have completed the procedure and need to
         * press a button to replay/quit/select a new treatment/go to main menu.
         */

        menuButtons.SetActive(true);
    }
}