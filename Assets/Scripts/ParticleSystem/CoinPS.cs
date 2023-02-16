using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPS : MonoBehaviour
{
    [SerializeField] private ParticleSystem stars;
    [SerializeField] private GameObject coin;

    

    private void OnTriggerEnter(Collider other)
    {
        if(stars != null)
        {
            coin.SetActive(false);
            GlobalEventManager.SendCollectedCoin();
            stars.Play();
        }
        
    }

}
