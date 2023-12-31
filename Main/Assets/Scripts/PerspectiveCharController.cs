using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
//using UnityEditorInternal;
using UnityEngine;

public class PerspectiveCharController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _turnSpeed = 360;
    [SerializeField] private Animator animator;
    [SerializeField] private KeyCode actionKey = KeyCode.E; //default to E key
    private Vector3 _input;
    public AudioSource walkingSounds; 

    private void Update()
    {
        GatherInput();
        Look();
        //key press to trigger pet
        if (Input.GetKeyDown(actionKey))
        {
            animator.SetTrigger("Pet");
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void GatherInput()
    {
        _input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }

    private void Look()
    {
        if (_input == Vector3.zero) return;
        var relative = (transform.position + _input) - transform.position;
        var rot = Quaternion.LookRotation(relative, Vector3.up);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, _turnSpeed * Time.deltaTime);
    }

    private void Move()
    {
        _rb.MovePosition(transform.position + transform.forward * _input.normalized.magnitude * _speed * Time.deltaTime);
        
        // when move happens, set blend value to 1
        if (_input != Vector3.zero)
        {
            animator.SetFloat("Blend", 1f);
         //   walkingSounds.Play(); 
        }
        else
        {
            animator.SetFloat("Blend", 0f);
        }


    }
}
