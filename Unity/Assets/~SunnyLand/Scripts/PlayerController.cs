using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Fold Code:   CTRL + M + O
// UnFold Code: CTRL + M + P

namespace SunnyLand
{
    [RequireComponent(typeof(SpriteRenderer))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        public float speed = 5f;
        public int health = 100;
        public int damage = 50;
        public float maxVelocity = 5f;
        public float maxSlopeAngle = 45f;
        [Header("Grounding")] // Attribute
        public float rayDistance = .25f;
        public bool isGrounded = false;
        public bool isOnSlope = false;
        [Header("Croouch")]
        public bool isCrouching = false;
        public float jumpHeight = 2f;
        public int maxJumpCount = 2;
        public bool isJumping = false;
        [Header("Climb")]
        public float climbSpeed = 5f;
        public bool isClimbing = false;

        private Vector3 groundNormal = Vector3.up;
        private int currentJump = 0;
        private float inputH, inputV;

        //References
        private SpriteRenderer rend;
        private Rigidbody2D rigid;


        #region Unity Functions
        // Use this for initialization
        void Awake()
        {

            rend = GetComponent<SpriteRenderer>();
            rigid = GetComponent <Rigidbody2D> ();

        }

        // Update is called once per frame
        void Update()
        {
            PerformMove();
            PerformClimb();
            PerformJump();
        }
        void FixedUpdate()
        {

        }
        void OnDrawGizmos()
        {

        }
        #endregion

        #region Custom Functions
        public void Jump()
        {

        }
        public void Crouch()
        {

        }
        public void UnCrouch()
        {

        }
        public void Move(float horizontal)
        {
            // If horizontal input (if horizontal input doesnt equal 0)
            if(horizontal !=0)
            {
                rend.flipX = horizontal < 0;
            }
            // Store the horizontal input for later
            inputH = horizontal;

        }
        public void Climb(float vertical)
        {

        }
        public void Hurt(int damage)
        {

        }
        // Actions
        void PerformMove()
        {
            // Calculate our 'right' direction based on surface
            Vector3 right = Vector3.Cross(groundNormal, Vector3.forward);
            //Add force in the 'right' direction
            rigid.AddForce(right * inputH * speed);
            //Limit our velocity
            LimitVelocity();
        }
        void PerformClimb()
        {

        }
        void PerformJump()
        {

        }
        // Detectors
        void DetectClimbable()
        {

        }
        void DetectGround()
        {

        }
        void CheckGround (RaycastHit2D hit)
        {

        }
        void CheckEnemy (RaycastHit2D hit)
        {

        }
        // Helpers
        void LimitVelocity()
        {
            // Copy velocity to smaller variable name
            Vector3 vel = rigid.velocity;
            // If vel reaches max velocity
            if (vel.magnitude > maxVelocity)
            {
                // Cap the velocity
                vel = vel.normalized * maxVelocity;
            }
            // Overwrite old velocity with new velocity
            rigid.velocity = vel;
        }
        void StopClimbing()
        {

        }
        void EnablePhysics()
        {

        }
        void DisablePhysics()
        {

        }
        #endregion
    }
}