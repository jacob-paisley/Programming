using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

namespace GoneHome
{
    public class Death : MonoBehaviour
    {

        public UnityEvent onDeath;


        void OnTriggerEnter(Collider other)
        {
            // If the player hits an object that
            // triggers it
            if (other.name == "DeathZone" ||
                other.name.Contains("Enemy"))
            {
                // Ya gunna die
                onDeath.Invoke();
            }
        }
    }	
}
