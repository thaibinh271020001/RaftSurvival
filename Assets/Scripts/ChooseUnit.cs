using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseUnit : MonoBehaviour
{
    [SerializeField]
    private Unit _unit;

    private void OnMouseDown()
    {
        _unit.InstancetiateTankModule(gameObject.transform);
    }
}
