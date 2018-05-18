using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AHundredBalls
{
    public class Spawner : MonoBehaviour
    {
          public GameObject prefab; // Reference to object we want to spawn
        public float spawnDelay = 1f; // Delay of spawn (in seconds)
        

        // Use this for initialization
        void Start()
        {
            StartCoroutine(Spawn());
        }

        IEnumerator Spawn()
        {
            //Wait until spawn delay
            yield return new WaitForSeconds(spawnDelay);

            //Spawn an object
            Instantiate(prefab, transform.position, transform.rotation);

            //Start coroutine again
            StartCoroutine(Spawn());
        }
    }
}