using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RollABall
{

    public class CameraController : MonoBehaviour
    {

        public GameObject player;

        private Vector3 offset;


        // Use this for initialization
        void Start()
        {
            offset = transform.position - player.transform.position;
        }

        // LateUpdate to make sure the player has already moved for that frame
        void LateUpdate()
        {
            transform.position = player.transform.position + offset;
        }
    }
}