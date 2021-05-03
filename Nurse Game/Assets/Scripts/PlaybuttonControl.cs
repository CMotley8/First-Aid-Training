using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaybuttonControl : InteractableVideoUI
{
    public override void ButtonPress()
    {
        video.PlayPause();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig")
        {
            video.PlayPause();
        }
    }
}
