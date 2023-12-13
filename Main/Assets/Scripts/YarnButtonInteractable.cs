using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class YarnButtonInteractable : MonoBehaviour
{
    [SerializeField] private string conversationStartNode; // Set this in the Inspector

    public DialogueRunner dialogueRunner;
    public Button TheButton;

    void Start()
    {
        // Add a listener to your button
        TheButton.onClick.AddListener(StartDialogue);
    }

    private void StartDialogue()
    {
        if (dialogueRunner != null)
        {
            dialogueRunner.StartDialogue(conversationStartNode);
        }
    }
}
