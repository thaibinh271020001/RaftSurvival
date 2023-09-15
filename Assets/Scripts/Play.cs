using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    [SerializeField]
    private GameObject _choosePlayer;
    [SerializeField]
    private GameObject _body;

    void Start()
    {
        Instantiate(_choosePlayer, _body.transform.parent);
    }
}
