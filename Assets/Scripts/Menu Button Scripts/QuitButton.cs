using UnityEngine;

public class QuitButton : MonoBehaviour
{
    private void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig") //Checking for left or right hand's collider.
        {
            Application.Quit();
        }
    }
}