using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField]
    private GameObject _upgradeGrid;
    [SerializeField]
    private GameObject _tankModule;

    //private GameObject _parent;

    public void ExpandUnit()
    {
        gameObject.SetActive(false);
        UpgradeGrid();
    }

    public void UpgradeGrid()
    {
        _upgradeGrid.SetActive(true);
    }

    public void InstancetiateTankModule(Transform tankTranform)
    {
        Instantiate(_tankModule,tankTranform.parent);
        Time.timeScale = 1;
        _upgradeGrid.SetActive(false);
    }
}
