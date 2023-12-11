using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableTrigger : MonoBehaviour
{
    public GameObject theItem; 

    void OnTriggerStay ()
    {
       
           theItem.SetActive(true); 
    }
     void OnTriggerExit (){
       
           theItem.SetActive(false);
    
    }
}
