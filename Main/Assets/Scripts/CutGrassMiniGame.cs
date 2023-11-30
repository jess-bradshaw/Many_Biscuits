using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutGrassMiniGame : MonoBehaviour
{
    [SerializeField] private float BarSpeed = 0.5f;
    [SerializeField] private float HitAreaA = 100.0f;
    [SerializeField] private float HitAreaB = 100.0f;
    [SerializeField] private Image SkillBar;
    [SerializeField] private Image LongGrass;
    [SerializeField] private Image CutGrass;
    public KeyCode actionKey = KeyCode.Space;
    private bool isIncreasing = true;
    private int CutCounter = 0;
    [SerializeField] private int CutRequired = 3;
    [SerializeField] private float ReturnDelay = 2.0f;
    public Canvas MiniGameCanvas;
    public GameObject TriggerObject;
    //remove comment to add audio
    //public AudioClip hitSound;
    //public AudioClip missSound;
    //private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        SkillBar.fillAmount = 0f;
        CutGrass.gameObject.SetActive(false);
        LongGrass.gameObject.SetActive(true);
        CutCounter = 0;
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
                //audioSource.PlayOneShot(hitSound);

                if (CutCounter == CutRequired)
                {
                    Debug.Log("Success!");
                    LongGrass.gameObject.SetActive(false);
                    CutGrass.gameObject.SetActive(true);
                    CutCounter = 0; // Reset the counter
                    TriggerObject.SetActive(false);
                    StartCoroutine(ReturnToGame());

                }
            }
            else
            {
                Debug.Log("Miss");
                //add audio if you want
                //audioSource.PlayOneShot(missSound);
            }
        }
    }

    //return to game delay
    private IEnumerator ReturnToGame()
    {
        yield return new WaitForSeconds(ReturnDelay);
        MiniGameCanvas.gameObject.SetActive(false);
    }
}
