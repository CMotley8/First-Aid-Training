using UnityEngine;

public class CheckPlayerLocation : MonoBehaviour
{
    [Tooltip("This is the ChokingTreatment script that is attached to some GameObject in your hierarchy.")]
    public ChokingTreatment chokingTreatment;

    private void OnTriggerEnter(Collider col)
    {
        //Only allowing the first step and ignoring all colliders that are not assigned the Player tag.
        if (!chokingTreatment.step[1] && !chokingTreatment.step[2] && col.CompareTag("Player"))
        {
            chokingTreatment.step[0] = true;
        }
    }
}
