using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AHundredBalls
{

    public class Bucket : MonoBehaviour
    {

        public float speed = 10f;
        public Vector2 direction = Vector2.right;


        // Update is called once per frame
        void Update()
        {
            transform.position += (Vector3)direction * speed * Time.deltaTime;
        }
    }
}