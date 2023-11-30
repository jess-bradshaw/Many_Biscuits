using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WispLevels : MonoBehaviour
{
    public WispEmotion emotionUps;
    
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
}
