using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThirdPersCamera : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform orientartion;
    [SerializeField] private Transform player;
    [SerializeField] private Transform playerObj;
    [SerializeField] private Rigidbody rb;

    [SerializeField, Range(0, 10)] private float rotationSpeed;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        // rotate orientation
        Vector3 viewDir = player.position - new Vector3(transform.position.x, player.position.y, transform.position.z);
        orientartion.forward = viewDir.normalized;

        // rotate player obj
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 inputDir = orientartion.forward * verticalInput + orientartion.right * horizontalInput;

        if (inputDir != Vector3.zero)
            playerObj.forward = Vector3.Slerp(playerObj.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);
    }
}
