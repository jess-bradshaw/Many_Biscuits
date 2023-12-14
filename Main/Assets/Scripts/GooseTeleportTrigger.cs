using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooseTeleportTrigger : MonoBehaviour
{
    public GameObject objectToHide; // The GameObject to hide
    public GameObject objectToShow; // The GameObject to show
    public string triggeringTag = "Player"; // Tag of the GameObject that triggers the change
    public ParticleSystem SpawnEffect;

    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the correct tag
        if (other.CompareTag(triggeringTag))
        {
            if (objectToHide != null)
                objectToHide.SetActive(false); // Hide the object

            if (objectToShow != null)
                SpawnEffect.Play();
                objectToShow.SetActive(true); // Show the object
        }
    }
}
