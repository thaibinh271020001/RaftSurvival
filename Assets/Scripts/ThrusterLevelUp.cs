using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrusterLevelUp : MonoBehaviour
{
    [SerializeField]
    private GameObject _levelUpObject;
    [SerializeField]
    private Text _levelText;
    
    public int _currentLevel = 1;

    private float ecreaseSpeedPercent = 1.1f;

    private PlayerMovement _playerMovement;
    public static float ecreaseSpeed=0;

    private void Start()
    {
        _playerMovement = GameObject.Find("PlayerRaft").GetComponent<PlayerMovement>();
        _levelText.text = "Level " + _currentLevel.ToString();
        
    }

    private void OnMouseDown()
    {
        Time.timeScale = 1;
        LevelManager.isUpgrade = false;//disable upgrade grid
        _currentLevel++;
        _levelText.text = "Level " + _currentLevel.ToString();

        IncreaseSpeed();

        _levelUpObject.SetActive(false);//disbale upgrade unit

    }

    public void IncreaseSpeed()
    {
        float speedWereIncrease = _playerMovement._speed * ecreaseSpeedPercent;
        ecreaseSpeed = speedWereIncrease - _playerMovement._speed;
        _playerMovement._speed = speedWereIncrease;
    }
}
