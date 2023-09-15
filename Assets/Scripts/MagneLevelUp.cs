using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagneLevelUp : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> listLevel;
    [SerializeField]
    private GameObject _levelUpObject;

    public static int refIdUpgrade;

    [SerializeField]
    private Text _levelText;

    public int _currentLevel = 1;

    public float increaseRadius;
    [SerializeField]
    private Magnet _magnet;

    private void Start()
    {
        _levelText.text = "Level " + _currentLevel.ToString();
    }

    private void OnMouseDown()
    {

        if (_currentLevel < 4)
        {
            listLevel[_currentLevel].SetActive(true);
            listLevel[_currentLevel - 1].SetActive(false);

            VariableStatic._currentLevel++;
            VariableStatic.checkUpgrade[refIdUpgrade] = false;

            _currentLevel++;

            IncreaseRadius();

            _levelText.text = "Level " + _currentLevel.ToString();
            Time.timeScale = 1f;
            //End of upgrade
            LevelManager.isUpgrade = false;
            _levelUpObject.SetActive(false);

        }
    }

    public void IncreaseRadius()
    {
        _magnet._radius *= 1.4f;
        increaseRadius = _magnet._radius;
    }
}
