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
        thrownCountText.text = $"���� ���� ��: {allThrownCoinsCount}";
        fallenCountText.text = $"�Ѿ��� ���� ��: {fallenCoinsCount}";
        uprightCountText.text = $"�� �ִ� ���� ��: {uprightCoinsCount}";
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
