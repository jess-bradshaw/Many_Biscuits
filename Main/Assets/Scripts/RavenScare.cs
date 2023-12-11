using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RavenScare : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if collider is triggered {on trigger enter}
        // then scare the raven + mark as scared away 

        //if raven present and Wisp in trigger hold then scared emote. + decrease emotions by one level only. 
    }


    public GameObject particlePoof; 
    public GameObject standingRaven; 
    public GameObject flyingRaven; 

    void OnTriggerEnter ()
    {
       
           particlePoof.SetActive(true); 
           standingRaven.SetActive(false); 
           flyingRaven.SetActive(true); 
           // increase wisp emotions?
    }
    
}
