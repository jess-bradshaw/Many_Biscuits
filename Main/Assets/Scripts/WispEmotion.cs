using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WispEmotion : MonoBehaviour
{
    public int maxHeart = 100;
    public int currentHeart;
    public int startHeart = 0;
    public int heartInc = 25;
    public int heartDec = 25;
    public EmotionBar emotion;
    public ParticleSystem Aura;



    // Start is called before the first frame update
    void Start()
    {
        currentHeart = startHeart;
        //emotion.SetMaxHeart(maxHeart);
        if (Aura != null && !Aura.isPlaying)
        {
            Aura.Stop(); // Ensure the particle system is not playing at start
        }

    }

    // Update is called once per frame
    
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeEmotion(heartInc);
        }*/
        
    }

    void UpdateParticleSystem()
    {
        if (Aura != null)
        {
            if (currentHeart >= 100 && !Aura.isPlaying)
            {
                Aura.Play(); // Play the particle system as currentHeart reaches 100
            }
            else if (currentHeart < 100 && Aura.isPlaying)
            {
                Aura.Stop(); // Stop the particle system if currentHeart drops below 100
            }
        }
    }

    public void IncEmotion(int Emotion)
    {

        currentHeart += Emotion;
        currentHeart = Mathf.Clamp(currentHeart, 0, maxHeart);
        emotion.SetHeart(currentHeart);
        UpdateParticleSystem();
    }

    public void DecEmotion(int Emotion)
    {

        currentHeart -= Emotion;
        currentHeart = Mathf.Clamp(currentHeart, 0, maxHeart);
        emotion.SetHeart(currentHeart);
        UpdateParticleSystem();
    }
}
