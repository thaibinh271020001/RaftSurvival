using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckLevelDamageTurret : MonoBehaviour
{
    [SerializeField]
    private GameObject _levelUpObject;
    [SerializeField]
    private Text _levelText;
    private int _currentLevel = 1;

    public float ecreaseDamage = 1;

    private void Start()
    {
        _levelText.text = "Level " + _currentLevel.ToString();
    }

    private void OnMouseDown()
    {
        Time.timeScale = 1;
        CameraRotate.IsUpgradeing = false;
        Play.isProtected = false;
        LevelManager.isUpgrade = false;//disable upgrade grid
        _currentLevel++;
        _levelText.text = "Level " + _currentLevel.ToString();

        ecreaseDamage *= 1.2f;

        _levelUpObject.SetActive(false);//disbale upgrade unit

    }
}
