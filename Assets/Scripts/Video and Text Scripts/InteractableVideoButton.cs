using UnityEngine;

public abstract class InteractableVideoButton : MonoBehaviour
{
    [Tooltip("This is the Video script component.")]
    public Video video;

    public abstract void ButtonPress();
}