using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeGrid : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefabsUpgrade;
    void Start()
    {
        GameObject instantiateprefabsUpgrade = Instantiate(_prefabsUpgrade);
        instantiateprefabsUpgrade.transform.parent = transform;
        instantiateprefabsUpgrade.transform.localPosition = Vector3.zero;
    }
}
