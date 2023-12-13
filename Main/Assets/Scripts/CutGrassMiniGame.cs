using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class CutGrassMiniGame : MonoBehaviour
{
    [Header("Skill Check Hit Area")]
    [SerializeField] private float BarSpeed = 0.5f;
    [SerializeField] private float HitAreaA = 100.0f;
    [SerializeField] private float HitAreaB = 100.0f;
    [SerializeField] private Image SkillBar;
    [SerializeField] private GameObject LongGrass;
    [Header("Spawns Item On Success")]
    public bool useFoundItem;
    [SerializeField] private GameObject FoundItem;
    [Header("Mini Game is Trigger On Other Script")]
    public bool BramblesAreCut;
    //[SerializeField] private Image CutGrass;
    [Header("Skill Check Setup")]
    public KeyCode actionKey = KeyCode.Space;
    private bool isIncreasing = true;
    private int CutCounter = 0;
    [SerializeField] private int CutRequired = 3;
    [SerializeField] private float ReturnDelay = 2.0f;
    public Canvas MiniGameCanvas;
    public GameObject TriggerObject;
    public WispEmotion emotionGain;
    //remove comment to add audio
    public AudioClip hitSound;
    public AudioClip missSound;
    public AudioClip CompleteSound;
    public AudioSource audioSource;
    public ParticleSystem HitEffect;
    public ParticleSystem CompleteEffect;
    public PerspectiveCharController playerController;
    public Animator playerAnimator;
    public CinemachineVirtualCamera cinemachineCamera;

    // Start is called before the first frame update
    void Start()
    {
        SkillBar.fillAmount = 0f;
        //CutGrass.gameObject.SetActive(false);
        LongGrass.gameObject.SetActive(true);
        CutCounter = 0;
        if (playerController != null)
        {
            playerController.enabled = false;
            playerAnimator.SetFloat("Blend", 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Osscilate the bar
        SkillBar.fillAmount += BarSpeed * Time.deltaTime;

        if (SkillBar.fillAmount >= 1.0f || SkillBar.fillAmount <= 0.0f)
        {
            BarSpeed = -BarSpeed; // Reverse it
        }

        // Check for key press in the hit range
        if (Input.GetKeyDown(actionKey))
        {
            if (SkillBar.fillAmount >= HitAreaA && SkillBar.fillAmount <= HitAreaB)
            {
                CutCounter++;
                Debug.Log("Hit " + CutCounter);
                //add audio if you want
                HitEffect.Play();
                audioSource.PlayOneShot(hitSound);

                if (CutCounter == CutRequired)
                {
                    Debug.Log("Success!");
                    LongGrass.gameObject.SetActive(false);
                    //CutGrass.gameObject.SetActive(true);
                    CutCounter = 0; // Reset the counter
                    CompleteEffect.Play();
                    TriggerObject.SetActive(false);
                    BramblesAreCut = true;
                    audioSource.PlayOneShot(CompleteSound);
                    IncreaseWispEmotion();
                    if (useFoundItem && FoundItem != null)
                    {
                        FoundItem.SetActive(true); // Activate or use FoundItem here
                    }
                    StartCoroutine(ReturnToGame());

                }
            }
            else
            {
                Debug.Log("Miss");
                //add audio if you want
                audioSource.PlayOneShot(missSound);
            }
        }
    }

    //return to game delay
    private IEnumerator ReturnToGame()
    {
        yield return new WaitForSeconds(ReturnDelay);
        MiniGameCanvas.gameObject.SetActive(false);
        if (playerController != null)
        {
            playerController.enabled = true;
        }
        if (cinemachineCamera != null)
        {
            // Activate the Cinemachine camera
            cinemachineCamera.gameObject.SetActive(false);
        }
    }

    public void IncreaseWispEmotion()
    {
        emotionGain.IncEmotion(emotionGain.heartInc);
        Debug.Log("emotion up");
    }
}
