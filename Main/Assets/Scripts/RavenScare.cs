using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RavenScare : MonoBehaviour
{

    //public GameObject particlePoof; 
    public GameObject standingRaven; 
    public GameObject flyingRaven; 
    public GameObject RavensPresent; 
    public AudioSource RavenLeave; 
    public Animator LeavingAnimation; 

    void OnTriggerEnter ()
    {
       
           RavensPresent.SetActive(false); 
         //  particlePoof.SetActive(true); 
           standingRaven.SetActive(false); 
           flyingRaven.SetActive(true); 
           LeavingAnimation.enabled = true; 
           RavenLeave.Play(); 
           // increase wisp emotions?
    }

   void FlewAway ()
    {
        flyingRaven.SetActive(false); 
    }
    
    
}
