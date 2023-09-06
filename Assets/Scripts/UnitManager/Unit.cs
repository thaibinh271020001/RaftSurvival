using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField]
    private GameObject _tankModule;

    public void ExpandUnit()
    {
        LevelManager.isUpgrade = true;
        gameObject.SetActive(false);
        UpgradeGrid();
        Time.timeScale = 1f;
    }

    public void UpgradeGrid()
    {
        //.SetActive(true);
    }

    /*public void InstancetiateTankModule(GameObject tankTranform)
    {
        Instantiate(_tankModule,tankTranform.transform.position,transform.rotation,);
        Time.timeScale = 1;
    }*/
}
