using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaybuttonControl : InteractableVideoUI
{
    public override void ButtonPress()
    {
        video.PlayPause();
    }
}
