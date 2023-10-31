using UnityEngine;

public class WispIdleWanderState : WispBaseState
{
    float idleCountdown = 10.0f; 	
    public GameObject menu; 
     public override void EnterState (WispsStates wisp)
    {
        Debug.Log("Hello I am wandering."); 
        //something in here to track time? 
    }
    public override void UpdateState (WispsStates wisp)
    {
        if (idleCountdown >=0)
		 {
			 idleCountdown -= Time.deltaTime; 
			// Debug.Log(idleCountdown); 
		 }
        else {
			wisp.SwitchState(wisp.IdleState);
            idleCountdown = 10.0f; 
        }
    }
    public override void OnCollisionEnter (WispsStates wisp, Collision collision)
    {
            GameObject other = collision.gameObject; 
	        Debug.Log("We touch");
	        if (other.CompareTag("Player"))
		    {
			   //menu = GetComponentInChildren<GameObject>();
               //menu.SetActive(true); 
			   Debug.Log("eeeeeed.");
		    }
    }
}
