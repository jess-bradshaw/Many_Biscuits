using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSounds : MonoBehaviour
{
 public AudioSource footsteps; 

 void Update()
 {
    if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
    {
        footsteps.enabled = true; 
        Debug.Log("I did it"); 
    }
    else 
    {
        footsteps.enabled = false; 
        Debug.Log("We stopped moving"); 
    }
 }
}
