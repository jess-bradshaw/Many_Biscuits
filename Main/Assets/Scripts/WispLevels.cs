using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WispLevels : MonoBehaviour
{
    public WispEmotion emotionUps;
    public AudioClip EmotionSound;
    public AudioClip EmotionSound2;
    public AudioClip CrossOverSound;
    public AudioSource audioSource;
    public GameObject Portal;
    public AudioClip PortalSound;

    [YarnCommand("EmotionUp")]
    // Update is called once per frame
    public void IncreaseWispEmotion()
    {
        emotionUps.IncEmotion(emotionUps.heartInc);
        Debug.Log("I work");
    }

    [YarnCommand("EmotionDown")]
    // Update is called once per frame
    public void DecreaseWispEmotion()
    {
        emotionUps.DecEmotion(emotionUps.heartInc);
        Debug.Log("I work");
    }

    [YarnCommand("EmotionSound")]
    // Update is called once per frame
    public void PlayEmotionSound()
    {
        audioSource.PlayOneShot(EmotionSound);
    }

    [YarnCommand("EmotionSound2")]
    public void PlayEmotionSound2()
    // Update is called once per frame
    {
        audioSource.PlayOneShot(EmotionSound2);
    }

    [YarnCommand("CrossOverSound")]
    public void PlayCrossOverSound()
    // Update is called once per frame
    {
        audioSource.PlayOneShot(CrossOverSound);
    }

    [YarnCommand("Portal")]
    public void PlayPortal()
    // Update is called once per frame
    {
        audioSource.PlayOneShot(PortalSound);
        Portal.SetActive(true);
        //Portal.Play();
    }
}
