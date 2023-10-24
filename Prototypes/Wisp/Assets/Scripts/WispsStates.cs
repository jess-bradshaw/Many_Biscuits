using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WispsStates : MonoBehaviour
{
    Animator wisp_Animator;
    float wisp_CurrentState; 
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        wisp_Animator = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (wisp_Animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            Debug.Log("is Idle"); 
        }
    }

    public void wispStates()
    {
    // public AnimatorStateInfo = GetCurrentAnimatorStateInfo(); 
        //   if (sleeping)
        { //wake up
        }

      //  if (idle)
        {
            //idle dance after a while move idle  
        }

        // if (following)
        { 
        //follow 
        }
    }





}
