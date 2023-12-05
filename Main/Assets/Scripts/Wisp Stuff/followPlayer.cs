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
        if (isFollowing == true) 
        {
            nav.SetDestination(target.position); 
        }
        else {
            nav.SetDestination(homeLocation.position);
        }
    }
    
   public void FollowPlayer ()
    {
        Debug.Log("Follow was pressed.");
       if (isFollowing == false) 
       {
        isFollowing = true; 
        menu.SetActive(false); }
        else 
        {
            Debug.Log("dismiss was pressed.");
        isFollowing = false; 
        menu.SetActive(false); 
        }
    }
      public void GoHome ()
    {
        Debug.Log("dismiss was pressed.");
        nav.SetDestination(homeLocation.position);
        isFollowing = false; 
        menu.SetActive(false); 
    }
}
