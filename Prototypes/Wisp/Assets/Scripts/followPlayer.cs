using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class followPlayer : MonoBehaviour
{
    public Transform target;
    NavMeshAgent nav; 
    public Transform homeLocation; 
    public bool isFollowing; 
    public GameObject menu; 
    
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (wispState == follow)
        // {
        if (isFollowing == true){
        nav.SetDestination(target.position);
        }

       // }

    }
    void OnTriggerStay (){
        if (Input.GetKeyDown(KeyCode.E))
        {
           menu.SetActive(true); 
           Debug.Log("eeeeeed.");
        }
    }
   public void FollowPlayer ()
    {
        Debug.Log("Follow was pressed.");
        nav.SetDestination(target.position);
        isFollowing = true; 
        menu.SetActive(false); 
    }
      public void GoHome ()
    {
        Debug.Log("dismiss was pressed.");
        nav.SetDestination(homeLocation.position);
        isFollowing = false; 
        menu.SetActive(false); 
    }
}
