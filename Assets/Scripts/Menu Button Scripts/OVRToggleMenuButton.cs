using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVRToggleMenuButton : MonoBehaviour
{
    public GameObject menuButtons;

    void Update()
    {
        // If the menu button on the controller is released during this frame.
        if(OVRInput.GetUp(OVRInput.Button.Start))
        {
            menuButtons.SetActive(!menuButtons.activeInHierarchy);
        }
    }
}
