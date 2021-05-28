using UnityEngine;

public class PreviousVideoButton : InteractableVideoButton
{
    public override void ButtonPress()
    {
        video.PreviousClip();
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig") //Checking for either left hand or right hand's collider.
        {
            video.PreviousClip();
            video.playButtonRenderer.material = video.pauseButtonMaterial;
        }
    }
}
