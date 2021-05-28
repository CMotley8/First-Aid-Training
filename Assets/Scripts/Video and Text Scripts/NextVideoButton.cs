using UnityEngine;

public class NextVideoButton : InteractableVideoButton
{
    public override void ButtonPress()
    {
        video.NextClip();
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig") //Checking for either left hand or right hand's collider.
        {
            video.NextClip();
            video.playButtonRenderer.material = video.pauseButtonMaterial;
        }
    }
}