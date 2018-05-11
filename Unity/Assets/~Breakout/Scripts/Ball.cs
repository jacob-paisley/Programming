using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{

    public class Ball : MonoBehaviour
    {

        public float speed = 5f;

        private Vector3 velocity; // direction x speed

        public void Fire (Vector3 direction)
        {
            //velocity is direction x speed
            velocity = direction * speed;
        }


        void OnCollisionEnter2D(Collision2D collision)
        {
            //grab contact point of collision (what they use for bullet holes in games)
            ContactPoint2D contact = collision.contacts[0];
            //Calculate reflection of contact
            Vector3 reflect = Vector3.Reflect(velocity, contact.normal);
            //Apply new reflect vaule]
            velocity = reflect.normalized * speed;
        }
        
        // Update is called once per frame
        void Update()
        {
            // Move the ball
            transform.position += velocity * Time.deltaTime;
        }
    }
}