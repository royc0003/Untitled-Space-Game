using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.InteropServices;
//using System.Runtime.Remoting.Messaging;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class ThirdPersonMovement : MonoBehaviour
{
    //For character control
    public CharacterController controller;
    public Transform cam;
    public float speed = 15f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public Animator animator;
    Vector3 velocity;
    public bool movement = true;
    public float height = 0.5f;
    public float heightPadding = 0.05f;

    public float maxGroundAngle = 120;
    public bool debug; //Draw debug lines
    float groundAngle;//Check current ground angle
    Vector3 forward;
    RaycastHit hitInfo;
    bool grounded;

    //For jumping and gravity
    public float jumpForce = 10;
    public float jumpHeight = 3f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float gravity = -9.81f;

  

  /*  private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Bg1")
        {
            FindObjectOfType<AudioManager>().Play("Background1");
        }

    }*/

        // Update is called once per frame
        void Update()
    {

        if (Input.GetMouseButtonDown(0) && !animator.GetCurrentAnimatorStateInfo(0).IsName("attack"))
        {
            animator.SetTrigger("attack");
            FindObjectOfType<AudioManager>().Play("Eattack");
        }

        animator.SetInteger("playerState", 0);

        //check if player is on the ground
        bool isGrounded = Physics.CheckSphere(groundCheck.position, 0.15f, groundLayer);
        //just to force player on the ground between frames (can be velocity.y = 0f also)
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //Player movement (up, down left, right)
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        //Player movement



        if (movement == true)
        {
            if (direction.magnitude >= 0.1f)
            {
                PlayerMovement(direction);
            }
        }

        DrawDebugLines();
        CalculateForward();
        CalculateGroundAngle();
        CheckGround();
        ApplyGravity();

        //set animation back to idle
        if (direction.magnitude < 0.1f)
        {
            animator.SetInteger("playerState", 0);
            animator.SetBool("Running", false);
        }

        //Jump and gravity input
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }

        //Jump plus gravity for the player to move down if he is in the air
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("attack");
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("attack"))
        {
            // do something
            movement = false;
            //print("ANimation is playing");
        }
        else
        {
            movement = true;
        }


        if (Input.GetKeyDown(KeyCode.C) && !animator.GetCurrentAnimatorStateInfo(0).IsName("attack"))
        {
            animator.SetTrigger("attack");
        }
    }

    void PlayerMovement(Vector3 direction)
    {
        animator.SetInteger("playerState", 1);
        animator.SetTrigger("Run");
        animator.SetBool("Running", true);

        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
        transform.rotation = Quaternion.Euler(0f, angle, 0f); //Rotate person in direction he is heading

        //final direction
        Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
        if (groundAngle < maxGroundAngle)
        {
            controller.Move(moveDir.normalized * speed * Time.deltaTime); //Only move when ground is less than the ground angle
        }

    }

    //If player is not grounded, forward will be equal to transform forward
    //Use a cross product to determine the new forward vector
    void CalculateForward()
    {
        if (grounded)
        {
            forward = transform.forward;
            return;
        }

        forward = Vector3.Cross(transform.right, hitInfo.normal); //Cross product of Y axis and Xaxis to get the forward direction or Z axis
    }

    //User a vector 3 angle between the ground normal and the transform forward to determine the slope of object
    void CalculateGroundAngle()
    {
        if (grounded)
        {
            groundAngle = 90;
            return;
        }

        groundAngle = Vector3.Angle(hitInfo.normal, transform.forward);
    }

    //Use a raycast of length height to determine whether or not the player is grounded
    void CheckGround()
    {
        if (Physics.Raycast(transform.position, Vector3.up, out hitInfo, height + heightPadding, groundLayer))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
        //Debug.Log("Grounded is " + grounded); 
    }

    //If not grounded, the player should fall
    void ApplyGravity()
    {
        if (!grounded)
        {
            transform.position += Physics.gravity * Time.deltaTime;
        }
    }


    //Draw debug lines for the grounded check, the height and the height padding
    void DrawDebugLines()
    {
        if (!debug) return;

        Debug.DrawLine(transform.position, transform.position + forward * height * 2, Color.blue); //Draw a line from (start,end) to see the angle of the player wrt to ground
        Debug.DrawLine(transform.position, transform.position - Vector3.up * height, Color.green);
    }
    void Jump()
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        FindObjectOfType<AudioManager>().Play("Jump");
        animator.SetInteger("playerState", 3);
        animator.SetTrigger("Jump");
    }

}