using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousButtonControl : InteractableVideoUI
{
    public override void ButtonPress()
    {
        video.PreviousClip();
    }

    void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig")
        {
            video.PreviousClip();
            video.playButtonRenderer.material = video.pauseButtonMaterial;
        }
    }
}
