using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform player;
        [SerializeField] private float sensitivity;
        private Vector3 offset;
        private float rotationX = 0f;
        private float rotationY = 0f;



        void Start()
        {
            offset = transform.position - player.position;
        }

        private void Update()
        {
            Rotate();
            
        }

        private void FixedUpdate()
        {
            transform.position = player.position + offset;
        }
        private void Rotate()
        {
            rotationX += Input.GetAxis(GlobalStringVars.MouseX) * sensitivity;
            rotationY += Input.GetAxis(GlobalStringVars.MouseY) * -1 * sensitivity;
            transform.localEulerAngles = new Vector3(rotationY, rotationX, 0);

        }

    }
}

