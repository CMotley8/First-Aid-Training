using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableVideoUI : MonoBehaviour
{
    public Video video;

    public abstract void ButtonPress();
}
