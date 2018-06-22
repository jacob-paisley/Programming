using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment1
{


    public class PatrolEnemy : MonoBehaviour
    {
        public Transform waypointGroup;
        public float movementSpeed = 5f;
        public float closeness = 1f;

        private Transform[] waypoints;
        private int currentIndex = 0;


        // Use this for initialization
        void Start()
        {
            int length = waypointGroup.childCount;
            waypoints = new Transform[length];
            for (int i = 0; i < length; i++)
            {
                waypoints[i] = waypointGroup.GetChild(i);
            }
        }

        // Update is called once per frame
        void Update()
        {
            //Get current waypoint
            Transform current = waypoints[currentIndex];
            //Move enemy towards current transform
            Vector3 position = transform.position;
            Vector3 direction = current.position - position;
            position += direction.normalized * movementSpeed * Time.deltaTime;
            transform.position = position;

            // Get distance from current waypoint to Enemy
            float distance = Vector3.Distance(current.position, position);
            // Check if distance is within range (closeness)
            if (distance <= closeness)
            {
                // Switch to next waypoint
                currentIndex++;
            }

            //If currentIndex goes outside array
            if (currentIndex >= waypoints.Length)
            {
                //Reset back to zero
                currentIndex = 0;
            }
        }
    }
}