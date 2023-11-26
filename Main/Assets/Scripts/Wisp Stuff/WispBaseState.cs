using UnityEngine;

public abstract class WispBaseState
{
   public abstract void EnterState (WispsStates wisp);

   public abstract void UpdateState(WispsStates wisp); 

 //  public abstract void OnTriggerEnter(WispsStates wisp, Collider other); 

}
