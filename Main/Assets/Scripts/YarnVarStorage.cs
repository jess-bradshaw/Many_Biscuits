using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnVarStorage : MonoBehaviour
{
    public WispEmotion wispEmotions; // Reference to the WispEmotions script
    public GameObject objectToDisable; // GameObject to disable
    public GameObject objectToEnable;  // GameObject to enable
    public int triggerValue = 50;        // The value to trigger the toggle

    private bool hasTriggered = false;   // To ensure the toggle happens only once

    void Update()
    {
        // Check if the trigger condition is met and has not yet triggered
        if (!hasTriggered && wispEmotions.currentHeart >= triggerValue)
        {
            // Enable/Disable the triggers
            if (objectToDisable != null)
                objectToDisable.SetActive(false);

            if (objectToEnable != null)
                objectToEnable.SetActive(true);

            hasTriggered = true; // Set the flag to prevent re-triggering
        }
    }
}
