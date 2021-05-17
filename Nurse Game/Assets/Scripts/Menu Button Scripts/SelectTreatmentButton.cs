using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectTreatmentButton : MonoBehaviour
{
    [Tooltip("This is the GameObject for the initial buttons (Main Menu/Replay/Select Treatment).")]
    public GameObject initialButtons;
    [Tooltip("This is the GameObject for the buttons that appear after you press the Select Treatment button.")]
    public GameObject treatmentTypeButtons;
    
    void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig")
        {
            initialButtons.SetActive(false);
            treatmentTypeButtons.SetActive(true);
        }
    }

    /*
     * Can use this for the specific scene buttons.

    void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig")
        {
            LoadScene(sceneName);
        }
    }

    void LoadScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }*/
}