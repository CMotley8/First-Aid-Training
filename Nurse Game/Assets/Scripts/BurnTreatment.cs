using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnTreatment : MonoBehaviour
{
    public bool[] step = new bool[3];
    private OVRGrabbable oVRGrabbable;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Wet Towel" && !step[1] && !step[2])
        {
            step[0] = true;
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed)
            {
                col.gameObject.SetActive(false);
            }
        }
        if(col.gameObject.tag == "Sterile Patch" && step[0] && !step[2])
        {
            step[1] = true;
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed)
            {
                col.gameObject.SetActive(false);
            }
        }
        if (col.gameObject.tag == "Gauze" && step[0] && step[1])
        {
            step[2] = true;
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed)
            {
                col.gameObject.SetActive(false);
            }
            Completed();
        }
    }

    void Completed()
    {
        // Placeholder; when the checklist is implemented there can be a big checkmark on the checklist.
        Debug.Log("The patient's burn as been treated!");
    }
}