using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] private GameObject toolTipPanel;
    [SerializeField] private GameObject leftDoor;
    [SerializeField] private GameObject rightDoor;
    [SerializeField] private GameObject topDoor;    

    private bool open = false;
    private float desiredDuration = 3f;
    private float elapsedTime;

    #region Doors start positions
    private Vector3 leftDoorStartPosition;
    private Vector3 rightDoorStartPosition;
    private Vector3 topDoorStartPosition;
    #endregion
    #region Doors end positions
    private Vector3 leftDoorEndPosition;
    private Vector3 rightDoorEndPosition;
    private Vector3 topDoorEndPosition;
    #endregion

    private void Start()
    {
        toolTipPanel.SetActive(false);
        leftDoorStartPosition = leftDoor.transform.position;
        rightDoorStartPosition = rightDoor.transform.position;
        topDoorStartPosition = topDoor.transform.position;

        leftDoorEndPosition = new Vector3(leftDoorStartPosition.x -1, leftDoorStartPosition.y, leftDoorStartPosition.z);
        rightDoorEndPosition = new Vector3(rightDoorStartPosition.x + 1, rightDoorStartPosition.y, rightDoorStartPosition.z);
        topDoorEndPosition = new Vector3(topDoorStartPosition.x, topDoorStartPosition.y + 1, topDoorStartPosition.z);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
            open = true;
        if (open)
            OpenDoor();
    }

    private void OnTriggerEnter(Collider other)
    {
        toolTipPanel.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        toolTipPanel.SetActive(false);
    }

    private void OpenDoor()
    {
        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / desiredDuration;
        leftDoor.transform.position = Vector3.Lerp(leftDoorStartPosition, leftDoorEndPosition, percentageComplete);
        rightDoor.transform.position = Vector3.Lerp(rightDoorStartPosition, rightDoorEndPosition, percentageComplete);
        topDoor.transform.position = Vector3.Lerp(topDoorStartPosition, topDoorEndPosition, percentageComplete);
    }
}
