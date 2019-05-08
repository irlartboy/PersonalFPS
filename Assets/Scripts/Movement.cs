using UnityEngine;
using System.Collections;
[RequireComponent(typeof(CharacterController))]

public class Movement : MonoBehaviour
{
    #region Varibles
    public float runSpeed = 12f;
    public float walkSpeed = 6f;
    public float gravity = -15f;
    public float jumpHeight = 8f;
    public LayerMask groundLayer;
    public float groundRayDistance = 1.1f;

    private CharacterController controller;
    private Vector3 motion;
    private bool isJumping = false;
    #endregion
    #region Start
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    #endregion
    #region Update
    void Update()
    {
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        bool inputJump = Input.GetButtonDown("Jump");

        // Normalize makes the diagonal movemnt more smooth 
        Vector3 normalized = new Vector3(inputH, 0f, inputV);
        normalized.Normalize();
        Move(normalized.x, normalized.z);

        // if grounded and pressed jump
        if (IsGrounded() && inputJump)
        {
            Jump(jumpHeight);
        }
        // if is grounded and not jumping 
        if (IsGrounded() && !isJumping)
        {
            motion.y = 0f;
        }

        // if is not grounded and is jumping 
        if (!IsGrounded() && isJumping)
        {
            isJumping = false;
        }
        motion.y += gravity * Time.deltaTime;




        // Applies motion to CharaterController
        controller.Move(motion * Time.deltaTime);
    }
    #endregion

    // This function tests if the player is grounded
    private bool IsGrounded()
    {
        Ray groundRay = new Ray(transform.position, -transform.up);
        if (Physics.Raycast(groundRay, groundRayDistance, groundLayer))
        {
            return true; 
        }
        return false;
    }

    public void Move(float horizontal, float vertical)
    {
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        direction = transform.TransformDirection(direction);

        motion.x = direction.x * walkSpeed;
        motion.z = direction.z * walkSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            motion.x = direction.x * runSpeed;
            motion.z = direction.z * runSpeed;
        }
    }

    public void Jump(float height)
    {
        motion.y = height;
        isJumping = true;
    }
}










