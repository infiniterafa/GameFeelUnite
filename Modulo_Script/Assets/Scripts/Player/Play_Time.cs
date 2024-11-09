using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Play_Time : MonoBehaviour
{
    public TMP_Text timerText;

    private void Update()
    {
        timerText.text = GameManager.Instance.GetTimerString();
    }
}
