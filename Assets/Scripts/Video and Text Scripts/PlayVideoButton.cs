using UnityEngine;

public class PlayVideoButton : InteractableVideoButton
{
    public override void ButtonPress()
    {
        video.PlayPause();
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig") //Checking for either left hand or right hand's collider.
        {
            video.PlayPause();
        }
    }
}