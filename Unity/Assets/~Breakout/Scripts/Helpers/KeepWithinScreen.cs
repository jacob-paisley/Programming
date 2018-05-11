using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{
    [RequireComponent(typeof(Renderer))] // Force Renderer component to be attached
    public class KeepWithinScreen : MonoBehaviour
    {
        private Renderer rend; //Renderer attached to the the object
        private Camera cam; //Camera container (variable)
        private Bounds camBounds; //camera bounds structure
        private float camWidth, camHeight;

        // Use this for initialization
        void Start()
        {
            //Set Camera variable to main camera
            cam = Camera.main;
            //get the renderer component attached to this object
            rend = GetComponent<Renderer>();
        }

        //updates the camBounds variable with the camera values
        void UpdateCamBounds()
        {
            //calculate camera bounds
            camHeight = 2f * cam.orthographicSize; // height = 2 x orthographic size
            camWidth = camHeight * cam.aspect; // width = height x aspect
            camBounds = new Bounds(cam.transform.position, new Vector3(camWidth, camHeight));
        }

        Vector3 CheckBounds()
        {
            Vector3 pos = transform.position;
            Vector3 size = rend.bounds.size;
            float halfWidth = size.x * 0.5f;
            float halfHeight = size.y * 0.5f;
            float halfCamWidth = camHeight * 0.5f;
            float halfCamHeight = camHeight * 0.5f;
            //check left
            if (pos.x - halfWidth < camBounds.min.x)
            {
                pos.x = camBounds.min.x + halfWidth;
            }
            //check right
            if (pos.x + halfWidth > camBounds.min.x)
            {
                pos.x = camBounds.min.x + halfWidth;
            }
            //check down
            if (pos.y - halfHeight < camBounds.min.y)
            {
                pos.y = camBounds.min.y + halfHeight;
            }
            //check up
            if (pos.y + halfHeight > camBounds.min.y)
            {
                pos.y = camBounds.max.y - halfHeight;
            }
            return pos; //returns adjusted position
        }

        // Update is called once per frame
        void Update()
        {
            //update the camera bounds
            UpdateCamBounds();
            //set the position after checking the bounds
            transform.position = CheckBounds();
        }
    }
}