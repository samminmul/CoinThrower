using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public TMP_Text thrownCountText, fallenCountText, uprightCountText;

    private int allThrownCoinsCount, fallenCoinsCount, uprightCoinsCount = 0;

    private void Start()
    {
        ShowCurStatusText();
    }

    private void ShowCurStatusText()
    {
        thrownCountText.text = $"던진 동전 수: {allThrownCoinsCount}";
        fallenCountText.text = $"넘어진 동전 수: {fallenCoinsCount}";
        uprightCountText.text = $"서 있는 동전 수: {uprightCoinsCount}";
    }

    public void AddThrownCoinsCount(int count)
    {
        allThrownCoinsCount += count;
        ShowCurStatusText();
    }

    public void AddFallenCoinsCount(int count) 
    {
        fallenCoinsCount += count;
        uprightCoinsCount = allThrownCoinsCount - fallenCoinsCount;
        ShowCurStatusText();
    }
}
