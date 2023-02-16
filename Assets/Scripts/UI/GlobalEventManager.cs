using UnityEngine;
using System;

public class GlobalEventManager : MonoBehaviour
{
    public static event Action OnCoinCollected;
    public static void SendCollectedCoin()
    {
        if (OnCoinCollected != null) OnCoinCollected.Invoke();
    }
}
