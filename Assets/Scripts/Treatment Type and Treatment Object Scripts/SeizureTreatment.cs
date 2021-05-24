using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeizureTreatment : Treatment
{
    [Tooltip("This is the GameObject for Menu buttons.")]
    public GameObject menuButtons;
    [Tooltip("This is the animator attached to the dummy.")]
    public Animator animator;
    public bool havingSeizure;
    public bool onSide;
    [Tooltip("This is the number of steps the treatment has.")]
    public bool[] step = new bool[0]; //Change this to the correct amount of steps.

    void Update()
    {
        if(havingSeizure)
        {
            animator.SetBool("havingSeizure", true);
        }
        else
        {
            animator.SetBool("havingSeizure", false);
        }
        if(onSide)
        {
            animator.SetBool("onSide", true);
        }
        else
        {
            animator.SetBool("onSide", false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        /*
         * Need to figure out how to do the seizure interaction.
         * Turning the dummy onto its side is probably more time consuming if we make the player actually turn
         *  the dummy onto its side. We could just place a collider on the leg and side of the body and then check
         *  if the player has their hands on those locations— and then change the dummy's animation to laying on its
         *  side (haven't found an animation for that yet).
         *  
         * The collider that needs to be checked for is the LeftGrabVolumeBig/RightGrabVolumeBig from the OVRHands.
         * Also check if the steps are done in the correct order.
         * 
         * Switch between animations by changing the bool in the animator. (example done above in update)
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
        /*
         * Change the step instructions to tell the player they have completed the procedure and need to
         * press a button to replay/quit/select a new treatment/go to main menu. 
         */

        menuButtons.SetActive(true);
    }
}