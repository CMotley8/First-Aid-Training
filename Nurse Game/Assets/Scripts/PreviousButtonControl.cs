using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousButtonControl : InteractableVideoUI
{
    public override void ButtonPress()
    {
        video.PreviousClip();
    }
}
