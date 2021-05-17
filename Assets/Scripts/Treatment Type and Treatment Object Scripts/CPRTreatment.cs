using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPRTreatment : Treatment
{
    [Tooltip("This is the number of steps the treatment has.")]
    public bool[] step = new bool[0]; //Change this to the correct amount of steps.

    void OnTriggerEnter(Collider col)
    {
        /*
         * Need to figure out how to do the CPR interaction.
         * My idea is to place a collider on the dummy's Bip002 Neck since that seems to be closest to the chest.
         * (can also make an empty gameobject as a child to a part of the dummy.)
         * and then ???.
         * The collider that needs to be checked for is the LeftGrabVolumeBig/RightGrabVolumeBig from the OVRHands.
         * Also check if the steps are done in the correct order.
         * 
         */
        if (!step[1] && !step[2])
        {
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed)
            {
                step[0] = true;
            }
        }
        if (step[0] && !step[2])
        {
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed)
            {
                step[1] = true;
            }
        }
        if (step[0] && step[1])
        {
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed)
            {
                step[2] = true;
            }
            Completed();
        }
    }
    public override void Completed()
    {
        throw new System.NotImplementedException();
    }
}