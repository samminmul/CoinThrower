using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    [SerializeField] GameObject coin;
    List<GameObject> coinList = new List<GameObject>();
    CoinCounter coinCounter;
    [SerializeField] private int row = 20;
    [SerializeField] private int col = 20;
    [SerializeField] private float gap = 50f;
    [SerializeField] private float coinInitYPos = 190f;

    private void Start()
    {
       coinCounter = GetComponent<CoinCounter>();
    }

    public void GenerateCoinsInGrid(int row, int col, float gap)
    {
        for (int i = 0; i < col; i++)
        {
            for (int j = 0; j < row; j++)
            {
                Vector3 coinLocation = new Vector3(i * gap, coinInitYPos, j * gap);
                coinList.Add(Instantiate(coin, coinLocation, Random.rotationUniform)) ;
            }
        }
        coinCounter.AddThrownCoinsCount(row * col);
    }

    public void GenerateCoinsInGridByCurSetting()
    {
        GenerateCoinsInGrid(row, col, gap);
    }

    public void DestroyAllCoins()
    {
        foreach (GameObject coin in coinList)
        {
            Destroy(coin);
        }
        coinList.Clear();
    }
}
