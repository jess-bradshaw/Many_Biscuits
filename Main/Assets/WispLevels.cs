using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WispLevels : MonoBehaviour
{
    public WispEmotion emotionUps;
    // Start is called before the first frame update


    [YarnCommand("EmotionUp")]
    // Update is called once per frame
    public void IncreaseWispEmotion()
    {
        emotionUps.TakeEmotion(emotionUps.heartInc);
        Debug.Log("I work");
    }
}
