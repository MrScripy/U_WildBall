using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] appearingObjects;
    [SerializeField] private GameObject trigger;

    private void Start()
    {
        trigger.SetActive(true);
        foreach(var i in appearingObjects)
        {
            i.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        trigger.SetActive(false);
        foreach (var i in appearingObjects)
        {
            i.SetActive(true);
        }
    }

}
