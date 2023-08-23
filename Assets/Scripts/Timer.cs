using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text _timerText;
    private float _curentTime;
    void Start()
    {
        _timerText = GetComponent<Text>();
    }

    void Update()
    {
        _curentTime = Time.timeSinceLevelLoad;
        UpdateTimeToDisplay();
    }

    private void UpdateTimeToDisplay()
    {
        int minutes = Mathf.FloorToInt(_curentTime / 60);
        int seconds = Mathf.FloorToInt(_curentTime % 60);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        _timerText.text = timeString;
    }
}
