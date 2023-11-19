using UnityEngine;

public class PlayerController_Ani : MonoBehaviour
{
    public float speed = 5.0f;
    private Vector2 moveInput = Vector2.zero;
    private CharacterController characterController;
    private Animator animator;
    private bool hasPat = true; // Boolean to track if the animation can be played

    private void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector3 moveDirection = new Vector3(moveInput.x, 0.0f, moveInput.y);

        if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection);
        }

        moveDirection.Normalize();
        characterController.Move(moveDirection * speed * Time.deltaTime);

        bool isWalking = moveDirection != Vector3.zero;
        animator.SetBool("isWalking", isWalking);

        // Check for 'P' key press to play animation
        if (Input.GetKeyDown(KeyCode.P) && hasPat)
        {
            animator.Play("MainCharacter_pat_01");
            hasPat = false; // Disable playing the animation until it completes
        }
    }

    // This function is called by an Animation Event at the end of the 'MainCharacter_pat_01' animation
    public void OnAnimationEnd()
    {
        hasPat = true; // Enable playing the animation again
    }
}
