using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class followPlayer : MonoBehaviour
{
    public Transform target;
    NavMeshAgent nav; 
    public 
    
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
        if (Input.GetKeyDown(KeyCode.E)) {
        Debug.Log("E key was pressed."); nav.SetDestination(target.position);
    }
       // }
    }
}
