using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private int allThrownCoinsCount, fallenCoinsCount = 0;

    public void AddThrownCoinsCount(int count)
    {
        allThrownCoinsCount += count;
    }

    public void AddFallenCoinsCount(int count) 
    {
        fallenCoinsCount += count;
        Debug.Log(fallenCoinsCount);
    }
}
