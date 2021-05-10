using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Treatment : MonoBehaviour
{
    protected OVRGrabbable oVRGrabbable;

    public abstract void Completed();

    public abstract void LoadScene(string sceneName);
}
