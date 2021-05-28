using UnityEngine;

public class CheckPlayerLocation : MonoBehaviour
{
    [Tooltip("This is the ChokingTreatment script that is attached to some GameObject in your hierarchy.")]
    public ChokingTreatment choking;
    private void OnTriggerEnter(Collider col)
    {
        //Only allowing the first step and ignoring all colliders that are not assigned the Player tag.
        if (!choking.step[1] && !choking.step[2] && col.CompareTag("Player"))
        {
            choking.step[0] = true;
        }
    }
}
