using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextVideoButton : InteractableVideoUI
{
    public override void ButtonPress()
    {
        video.NextClip();
    }

    void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig")
        {
            video.NextClip();
            video.playButtonRenderer.material = video.pauseButtonMaterial;
        }
    }
}
