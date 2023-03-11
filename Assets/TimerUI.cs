using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerUI : MonoBehaviour
{
    TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateTime(float time)
    {
        int minute = (int)(time / 60f);
        int seconds = (int)(time % 60f);

        text.text = minute.ToString() + ":" + seconds.ToString("00");
    }
}
