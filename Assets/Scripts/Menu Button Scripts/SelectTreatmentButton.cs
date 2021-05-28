using UnityEngine;

public class SelectTreatmentButton : MonoBehaviour
{
    [Tooltip("This is the GameObject for the initial buttons (Main Menu/Replay/Select Treatment).")]
    public GameObject initialButtons;
    [Tooltip("This is the GameObject for the buttons that appear after you press the Select Treatment button.")]
    public GameObject treatmentTypeButtons;

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig") //Checking for left or right hand's collider.
        {
            initialButtons.SetActive(false);
            treatmentTypeButtons.SetActive(true);
        }
    }
}