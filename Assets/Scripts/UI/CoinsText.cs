using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinsText : MonoBehaviour
{
    private int collected = 0;
    private int coinsAmmount;
    TextMeshProUGUI _TMP;

    void Start()
    {
        GlobalEventManager.OnCoinCollected += CoinsCollected;
        coinsAmmount = GameObject.FindGameObjectsWithTag("Coin").Length;
        _TMP = GetComponent<TextMeshProUGUI>();
        _TMP.text = $"Coins: {coinsAmmount}\nCollected: {collected}";
    }
    private void OnDestroy()
    {
        GlobalEventManager.OnCoinCollected -= CoinsCollected;
    }
    void CoinsCollected()
    {
        collected++;
        _TMP.text = $"Coins: {coinsAmmount}\nCollected: {collected}";
    }
}
