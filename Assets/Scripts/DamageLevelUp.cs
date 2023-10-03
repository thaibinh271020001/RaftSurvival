using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageLevelUp : MonoBehaviour
{
    [SerializeField]
    private GameObject _levelUpObject;

    [SerializeField]
    private Text _levelText;
    private int _currentLevel = 1;

    private float ecreaseDamagePercent = 1.1f;

    public static float ecreaseDamage = 0;

    private void Start()
    {
        _levelText.text = "Level " + _currentLevel.ToString();
    }

    private void OnMouseDown()
    {
        CameraRotate.IsUpgradeing = false;
        Time.timeScale = 1;
        Play.isProtected = false;
        LevelManager.isUpgrade = false;//disable upgrade grid
        _currentLevel++;
        _levelText.text = "Level " + _currentLevel.ToString();

        IncreaseDamage();

        _levelUpObject.SetActive(false);//disbale upgrade unit
    }

    public void IncreaseDamage()
    {
        float damageWereIncrease = DamageUnit.damageIncreaseByAttckUnit * ecreaseDamagePercent;
        ecreaseDamage = damageWereIncrease - DamageUnit.damageIncreaseByAttckUnit;
        DamageUnit.damageIncreaseByAttckUnit = damageWereIncrease;
        Debug.Log(ecreaseDamage);
    }



    /*[SerializeField]
    private GameObject _levelUpObject;
    [SerializeField]
    private Text _levelText;

    public int _currentLevel = 1;

    private float ecreaseDamagePercent = 1.1f;

    private PlayerMovement _playerMovement;
    public static float ecreaseDamage = 0;

    private void Start()
    {
        _levelText.text = "Level " + _currentLevel.ToString();

    }

    private void OnMouseDown()
    {
        Time.timeScale = 1;
        LevelManager.isUpgrade = false;//disable upgrade grid
        _currentLevel++;
        _levelText.text = "Level " + _currentLevel.ToString();

        IncreaseDamage();

        _levelUpObject.SetActive(false);//disbale upgrade unit

    }

    public void IncreaseDamage()
    {
        float damageWereIncrease = DamageUnit.damageIncreaseByAttckUnit * ecreaseDamagePercent;
        ecreaseDamage = damageWereIncrease - DamageUnit.damageIncreaseByAttckUnit;
        DamageUnit.damageIncreaseByAttckUnit = damageWereIncrease;
    }*/
}
