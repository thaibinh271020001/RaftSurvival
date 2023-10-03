using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoldierLevelUp : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> listLevel;
    [SerializeField]
    private GameObject _levelUpObject;

    public static int refIdUpgrade;

    [SerializeField]
    private Text _levelText;
    private int _currentLevel = 1;

    private void Start()
    {
        _levelText.text = "Level " + _currentLevel.ToString();
    }

    private void OnMouseDown()
    {
        Play.isProtected = false;
        if (_currentLevel < 4)
        {
            listLevel[_currentLevel].SetActive(true);
            listLevel[_currentLevel - 1].SetActive(false);

            VariableStatic._currentLevel++;
            VariableStatic.checkUpgrade[refIdUpgrade] = false;

            _currentLevel++;
            _levelText.text = "Level " + _currentLevel.ToString();
            CameraRotate.IsUpgradeing = false;

            Time.timeScale = 1f;
            //End of upgrade
            LevelManager.isUpgrade = false;
            _levelUpObject.SetActive(false);

        }
    }
}
