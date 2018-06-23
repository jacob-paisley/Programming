using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace Assessment1
{
    public class PlayerController : MonoBehaviour
    {

        public float speed;
        public Text countText;
        public Text winText;

        private Rigidbody rigid;
        private int count;
        private Vector3 spawnPoint;

            
        void Start()
        {
            rigid = GetComponent<Rigidbody>();
            count = 0;
            SetCountText ();
            winText.text = "";


            rigid = GetComponent<Rigidbody>();
            spawnPoint = transform.position;
        }


        //fixed update is for physics
        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

            rigid.AddForce (movement * speed);
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Pick Up"))
            {
                other.gameObject.SetActive (false);
                count = count + 1;
                SetCountText ();
            }
         }

        void SetCountText ()
        {
            countText.text = "Score: " + count.ToString();
            //if (count >= 12)
           // {
                //winText.text = "You Win!";
           // }
        }


        // Resets the player's settings when run
        public void Reset()
        {

            //// Reset player's position to start position
            //transform.position = spawnPoint;
            //// Reset player's velocity
            //rigid.velocity = Vector3.zero;
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.buildIndex);
        }


    }
}