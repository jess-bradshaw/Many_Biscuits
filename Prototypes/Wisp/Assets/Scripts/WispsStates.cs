using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WispsStates : MonoBehaviour
{
    public WispBaseState currentState; 
    public WispFollowState FollowingState = new WispFollowState();
    public WispPetState PetState = new WispPetState(); 
    public WispIdleState IdleState = new WispIdleState(); 
    public WispIdleWanderState WanderState = new WispIdleWanderState(); 
    
    // Start is called before the first frame update 
    void Start()
    {
            // Staring State for the state machine     
        currentState = IdleState; 
            //"this" is a reference to the context (this exact monobehaviour script)
        currentState.EnterState(this);
    }
    // Update is caleld once per frame 
    void Update()
    {
        currentState.UpdateState(this); 
    }

    public void SwitchState(WispBaseState state)
    {
        currentState = state; 
        state.EnterState(this); 
    }
}
