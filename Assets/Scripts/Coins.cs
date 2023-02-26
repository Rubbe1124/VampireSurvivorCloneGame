using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int cointAcquired;
    [SerializeField] TMPro.TextMeshProUGUI coinsCountText;

    public void Add(int count)
    {
        cointAcquired += count;
        coinsCountText.text = "Coins: " + cointAcquired.ToString();
    }
}
