using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Assessment1
{

    public class Goal : MonoBehaviour
    {

        public Text winText;

        public UnityEvent onTriggered;

        void Start()
        {
            winText.text = "";
        }

            // Runs function when collider enters trigger (Goal)
            void OnTriggerEnter(Collider other)
        {
            // Check if other is "Player"
            if (other.name == "Player")
            {

                winText.text = "Victory!";
                // Run 'onTriggered' event
                //onTriggered.Invoke();
            }
        }
    }
}