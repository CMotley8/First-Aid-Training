using UnityEngine;

public class BurnTreatment : Treatment
{
    [Tooltip("This is the GameObject for Menu buttons.")]
    public GameObject menuButtons;
    [Tooltip("This is the GameObject for the hydrogel dressing childed to the patient.")]
    public GameObject hydroGelDressing;
    [Tooltip("This is the GameObject for the gauze childed to the patient.")]
    public GameObject fakeGauze;
    [Tooltip("This is the number of steps the treatment has.")]
    public bool[] step = new bool[3];

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Wet Towel" && !step[1] && !step[2]) //Only allows the first step and checks for the gameobject with the Wet Towel tag assigned.
        {
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed) //Checking that the wet towel is not grabbed.
            {
                step[0] = true;
            }
        }
        if (col.gameObject.tag == "Sterile Dressing" && step[0] && !step[2]) //Only allows the second step and checks for the gameobject with the Sterile Dressing tag assigned.
        {
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed) //Checking that the sterile dressing is not grabbed.
            {
                step[1] = true;
                hydroGelDressing.SetActive(true);
                col.gameObject.SetActive(false);
            }
        }
        if (col.gameObject.tag == "Gauze" && step[0] && step[1]) //Only allows the third step and checks for the gameobject with the Gauze tag assigned.
        {
            oVRGrabbable = col.gameObject.GetComponent<OVRGrabbable>();
            if (!oVRGrabbable.isGrabbed) //Checking that the gauze is not grabbed.
            {
                step[2] = true;
                fakeGauze.SetActive(true);
                hydroGelDressing.SetActive(false);
                col.gameObject.SetActive(false);
                Completed();
            }
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