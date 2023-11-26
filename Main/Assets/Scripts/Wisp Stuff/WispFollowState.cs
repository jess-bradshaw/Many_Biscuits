using UnityEngine;

public class WispFollowState : WispBaseState
{
    public override void EnterState (WispsStates wisp)
    {
        Debug.Log("Hello I am following."); 
    }
    public override void UpdateState (WispsStates wisp)
    {

    }
   // public override void OnCollisionEnter (WispsStates wisp, Collision collision)
    //{

    //}
}

