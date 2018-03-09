using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

namespace GoneHome
{

    public class Goal : MonoBehaviour
    {

        public UnityEvent onTriggered;


        // Runs function when collider enters trigger (Goal)
        void OnTriggerEnter(Collider other)
        {
            // Check if other is "Player"
            if (other.name == "Player")
            {
                // Run 'onTriggered' event
                onTriggered.Invoke();
            }
        }
    }
}