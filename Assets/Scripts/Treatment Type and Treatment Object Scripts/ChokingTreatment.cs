using UnityEngine;

public class ChokingTreatment : Treatment
{
    [Tooltip("This is the GameObject for Menu buttons.")]
    public GameObject menuButtons;
    [Tooltip("This is the GameObject the person is choking on called 'Choking Object'.")]
    public GameObject chokingObject;
    [Tooltip("This is the number of steps the treatment has.")]
    public bool[] step = new bool[3];

    private bool leftHand;
    private bool rightHand;

    /*
	 * Can use OnTriggerExit to sort of simulate a pulling motion by detecting if the hands left the collider.
	 * Downside is that it is just detecting the collider leaving from any direction, so you could easily not do
	 *  a pulling motion and it would detect your hands leaving and still function as if you did a pulling motion.
	 */
    private void OnTriggerStay(Collider col)
    {
        if (step[0] && !step[2]) //Only allowing the second step.
        {
            if (col.name == "LeftGrabVolumeBig") //Left hand's collider.
            {
                leftHand = true;
                step[1] = true;
            }
            else if (col.name == "RightGrabVolumeBig") //Right hand's collider.
            {
                rightHand = true;
                step[1] = true;
            }
        }

        if (step[0] && step[1]) //Only allowing the third step.
        {
            if (col.name == "RightGrabVolumeBig" && leftHand) //Right hand's collider and left hand's collider was already detected.
            {
                rightHand = true;
                step[2] = true;
                Invoke("Completed", 10.0f); //After 10 seconds. Allows you to assume the player is doing the pulling motion.
            }
            else if (col.name == "LeftGrabVolumeBig" && rightHand) //Left hand's collider and right hand's collider was already detected.
            {
                leftHand = true;
                step[2] = true;
                Invoke("Completed", 10.0f); //After 10 seconds. Allows you to assume the player is doing the pulling motion.
            }
        }
    }

    public override void Completed()
    {
        /*
		 * Change the step instructions to tell the player they have completed the procedure and need to
		 * press a button to replay/quit/select a new treatment/go to main menu. 
		 */
        chokingObject.SetActive(true);
        menuButtons.SetActive(true);
    }
}