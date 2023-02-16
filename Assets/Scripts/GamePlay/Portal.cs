using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject secondPortal;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = secondPortal.transform.position;
    }

}
