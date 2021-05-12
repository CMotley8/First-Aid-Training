using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextTreatmentSceneButton : MonoBehaviour
{
    public int currentSceneIndex;
    public int nextSceneIndex;

    void Awake()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        nextSceneIndex = currentSceneIndex+1;
    }
    
    void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftGrabVolumeBig" || col.name == "RightGrabVolumeBig")
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadSceneAsync(nextSceneIndex);
    }
}