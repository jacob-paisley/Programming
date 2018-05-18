using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AHundredBalls
{
    [RequireComponent(typeof(Animator))]
    public class Paddle : MonoBehaviour
    {
        private Animator anim;

        // Use this for initialization
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetTrigger("Open");
            }
        }
    }
}