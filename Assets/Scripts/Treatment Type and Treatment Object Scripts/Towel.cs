using UnityEngine;

public class Towel : MonoBehaviour
{
    [Tooltip("This is the wet material for the towel.")]
    public Material wetMat;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Water")) //Ignores all colliders that do not have the Water tag assigned.
        {
            GetComponent<Renderer>().material = wetMat;
            gameObject.tag = "Wet Towel";
        }
    }
}