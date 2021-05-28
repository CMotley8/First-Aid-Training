using UnityEngine;

public class CPRTreatmentSceneButton : SceneButton
{
    private void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig") //Checking for left or right hand's collider.
        {
            LoadScene("CPR");
        }
    }
}