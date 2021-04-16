using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButtonControl : InteractableVideoUI
{
    public override void ButtonPress()
    {
        video.NextClip();
    }
}
