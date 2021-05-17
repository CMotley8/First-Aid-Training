using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableVideoUI : MonoBehaviour
{
    [Tooltip("This is the Video script component.")]
    public Video video;

    public abstract void ButtonPress();
}
