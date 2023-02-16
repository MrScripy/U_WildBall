using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private Transform orientation;
        [SerializeField] private float jumpForce = 10f;
        [SerializeField] private float jumpCoolDown;
        [SerializeField] private float airMultiplier;
        private bool readyToJump = true;

        private float horizontalInput;
        private float verticalInput;

        private Vector3 moveDir;

        private Rigidbody rb;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            rb.freezeRotation = true;
        }

        private void Update()
        {
            MyInput();
            Jump();
        }

        private void FixedUpdate()
        {
            MovePlayer();
        }

        private void MyInput()
        {
            horizontalInput = Input.GetAxis(GlobalStringVars.Horizontal);
            verticalInput = Input.GetAxis(GlobalStringVars.Vertical);                    
        }

        private void MovePlayer()
        {
            // walk in direction player's looking
            moveDir = orientation.forward * verticalInput + orientation.right * horizontalInput;
            rb.AddForce(moveDir.normalized * speed, ForceMode.VelocityChange);
        }

        private void Jump()
        {
            if(Input.GetKeyDown(KeyCode.Space) && readyToJump)
            {
                readyToJump = false;
                rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
                rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
                Invoke(nameof(ResetJump), jumpCoolDown);
            }            
        }

        private void ResetJump()
        {
            readyToJump = true;
        }

        
    }
}

