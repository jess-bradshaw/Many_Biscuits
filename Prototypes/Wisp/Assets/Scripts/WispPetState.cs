using UnityEngine;

public class WispPetState : WispBaseState
{
   public override void EnterState (WispsStates wisp){
       Debug.Log("Hello I am being pet."); 
   }
    public override void UpdateState (WispsStates wisp){

   }
    public override void OnCollisionEnter (WispsStates wisp, Collision collision){

   }
}
