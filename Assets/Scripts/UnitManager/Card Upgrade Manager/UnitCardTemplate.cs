using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitCardTemplate : MonoBehaviour
{
    public Text title;
    public Text description;
    public Image unitImg;
    public Text upgradeText;

    [SerializeField]
    private GameObject _unitPrefab;

    [SerializeField]
    private int _serialNumber;
    [SerializeField]
    private GameObject _textUpgrade;

    public static int numberCheckUnitCanUpgrade;

    private void Awake()
    {
        Time.timeScale = 0;
    }

    private void Start()
    {
        if (VariableStatic.numberCard != null)
        {
            foreach (int number in VariableStatic.numberCard)
            {
                if (number == _serialNumber )//& VariableStatic.isClicked == true)
                {
                    _textUpgrade.SetActive(true);
                    VariableStatic.checkUpgrade[_serialNumber] = true;
                }
            }
        }
    }
    public void Clicked()
    {
        CameraRotate.IsUpgradeing = true;
        Play.isProtected = true;
        VariableStatic.isClicked = true;
        VariableStatic.numberCard.Add(_serialNumber);
        LevelManager.isUpgrade = true;
        //ActiveChooseUnit();
        Time.timeScale = 1;

        VariableStatic.panelUpgradeIsShow = false;
        VariableStatic._unitPrefab = _unitPrefab;

        numberCheckUnitCanUpgrade = _serialNumber;
        //Display Ui upgrade when unit upgraded with serialNumber corresponds to each unit
        if ((VariableStatic.checkUpgrade[_serialNumber] == true)){
            VariableStatic.displayUIUpgrade = true;
        }
    }

    /*public void ActiveChooseUnit()
    {
        GameObject[] allObjects = GameObject.FindObjectsOfType<GameObject>();

        foreach (GameObject obj in allObjects)
        {
            if (obj.CompareTag("LeftUnit") && !obj.activeSelf)
            {
                obj.SetActive(true);
            }
        }

        GameObject[] leftUpgradeUnit = GameObject.FindGameObjectsWithTag("LeftUnit");
        GameObject[] rightUpgradeUnit = GameObject.FindGameObjectsWithTag("RightUnit");
        GameObject[] upUpgradeUnit = GameObject.FindGameObjectsWithTag("UpUnit");
        GameObject[] downUpgradeUnit = GameObject.FindGameObjectsWithTag("DownUnit");

        //Debug.Log(leftUpgradeUnit[0].name);

        foreach(var left in leftUpgradeUnit)
        {
            Debug.Log(left.gameObject.name);
            left.SetActive(true);
        }
        foreach(var right in rightUpgradeUnit)
        {
            right.SetActive(true);
        }
        foreach(var up in upUpgradeUnit)
        {
            up.SetActive(true);
        }
        foreach(var down in downUpgradeUnit)
        {
            down.SetActive(true);
        }
    }*/
}
