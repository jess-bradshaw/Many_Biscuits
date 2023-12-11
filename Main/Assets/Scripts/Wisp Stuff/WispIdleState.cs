using UnityEngine;

public class WispIdleState : WispBaseState
{
float idleCountdown = 10.0f; 	


public override  void EnterState (WispsStates wisp)

	{
		//Debug.Log("Hello I am idling."); 

   }
   public override void UpdateState (WispsStates wisp)
   {
	    // if (idleCountdown >=0)
		// {
		//	 idleCountdown -= Time.deltaTime; 
			// Debug.Log(idleCountdown); 
		// }
        //else {
		//	wisp.SwitchState(wisp.WanderState); 
		//	idleCountdown = 10.0f; 
       // }
   }
   private void OnTriggerEnter(Collider collider)
   {
	   GameObject other = collider.gameObject; 
	   Debug.Log("We touch");
	   if (other.CompareTag("Player"))
		   {
			  //menu = GetComponentInChildren<GameObject>();
               //menu.SetActive(true); 
			 //  Debug.Log("eeeeeed.");
		   }
   }

}
