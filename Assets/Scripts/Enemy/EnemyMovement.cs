using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameObject _targetPlayer;
    [SerializeField]
    private float _speed;
    private GameObject bullet;
    void Start()
    {
        _targetPlayer = GameObject.Find("PlayerPoint");
    }

    void Update()
    {
        transform.LookAt(_targetPlayer.transform, Vector3.up);
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
}
