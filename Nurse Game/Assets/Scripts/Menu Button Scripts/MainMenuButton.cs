using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig")
        {
            Debug.LogWarning("Load!");
            LoadMainMenu();
        }
    }

    void LoadMainMenu()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }
}