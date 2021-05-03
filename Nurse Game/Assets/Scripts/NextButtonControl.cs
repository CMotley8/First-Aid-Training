using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButtonControl : InteractableVideoUI
{
    public override void ButtonPress()
    {
        video.NextClip();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig")
        {
            video.NextClip();
        }
    }
}
