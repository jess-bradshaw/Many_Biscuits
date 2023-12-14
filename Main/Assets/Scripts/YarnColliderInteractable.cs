using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnColliderInteractable : MonoBehaviour
{
    [SerializeField] private string conversationStartNode; // Set this in the Inspector

    public DialogueRunner dialogueRunner;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider is the player
        if (other.CompareTag("Player") && dialogueRunner != null)
        {
            dialogueRunner.StartDialogue(conversationStartNode);
        }
    }
}
