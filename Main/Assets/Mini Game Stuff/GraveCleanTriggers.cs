using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;

public class GraveCleanTriggers : MonoBehaviour
{
    [Header("Disable Character Controller")]
    public PerspectiveCharController playerController;
    public Animator playerAnimator;
    [Header("Spawn Wisp")]
    public ParticleSystem SpawnEffect;
    public GameObject WispSpawn;
    [SerializeField] private float ReturnDelay = 2.0f;
    [Header("Target UI Text UI")]
    public TextMeshProUGUI textComponent;
    [Range(0, 100)] public int triggerPercentage;
    [Header("Trigger to delete")]
    public GameObject GameTrigger;
    public CinemachineVirtualCamera cinemachineCamera;
    public Canvas GraveGameCanvas;
    //public SolarPanel CleanPercent;
    // Start is called before the first frame update
    void Start()
    {
        if (playerController != null)
        {
            playerController.enabled = false;
            playerAnimator.SetFloat("Blend", 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckTextValue();
    }

    void CheckTextValue()
    {
        string expectedText = triggerPercentage + "%";
        if (textComponent.text == expectedText)
        {
            StartCoroutine(ReturnToGame());
            Debug.Log("i hit the percent");
            this.enabled = false; // Disable this check after triggering
        }
    }

    private IEnumerator ReturnToGame()
    {
        //GraveGameCanvas.gameObject.SetActive(false);
        if (cinemachineCamera != null)
        {
            // Activate the Cinemachine camera
            cinemachineCamera.gameObject.SetActive(false);
        }
        yield return new WaitForSeconds(ReturnDelay);
        Destroy(GameTrigger);
        SpawnEffect.Play();
        WispSpawn.gameObject.SetActive(true);
        GraveGameCanvas.gameObject.SetActive(false);
        if (playerController != null)
        {
            playerController.enabled = true;
        }
        
    }
}
