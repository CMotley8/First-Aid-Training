using UnityEngine;

//Currently only configured for Oculus devices using OVRInput.
public class ToggleMenuButton : MonoBehaviour
{
    [Tooltip("This is the GameObject in the hierarchy called Menu Buttons for the menu buttons.")]
    public GameObject menuButtons;

    private void Update()
    {
        // If the menu button on the left controller is released during this frame.
        if (OVRInput.GetUp(OVRInput.Button.Start))
        {
            menuButtons.SetActive(!menuButtons.activeInHierarchy);
        }
    }
}