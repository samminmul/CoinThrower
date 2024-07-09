using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    [SerializeField] GameObject coin;
    CoinCounter coinCounter;

    private void Start()
    {
       coinCounter = GetComponent<CoinCounter>();

        GenerateCoinsInGrid(20, 20, 50f);
    }

    public void GenerateCoinsInGrid(int row, int col, float gap)
    {
        for (int i = 0; i < col; i++)
        {
            for (int j = 0; j < row; j++)
            {
                Vector3 coinLocation = new Vector3(i * gap, 10f, j * gap);
                Instantiate(coin, coinLocation, Quaternion.identity);
            }
        }
        coinCounter.AddThrownCoinsCount(row * col);
    }
}
