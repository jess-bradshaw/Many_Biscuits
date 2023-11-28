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

    
    // Start is called before the first frame update
    void Start()
    {
        currentHeart = startHeart;
        //emotion.SetMaxHeart(maxHeart);
    }

    // Update is called once per frame
    
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeEmotion(heartInc);
        }*/
    }
   
    public void IncEmotion(int Emotion)
    {

        currentHeart += Emotion;
        emotion.SetHeart(currentHeart);
    }

    public void DecEmotion(int Emotion)
    {

        currentHeart -= Emotion;
        emotion.SetHeart(currentHeart);
    }
}
