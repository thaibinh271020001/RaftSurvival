using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundMovement : MonoBehaviour
{
    [SerializeField]
    private float _radius = 2f;
    [SerializeField]
    private float _angularSpeed = 2f;

    private float _angle = 0;
    private float _posX = 0, _posz = 0;

    private GameObject _player;

    [SerializeField]
    private Transform _transformRotate;
    [SerializeField]
    private float _speedRotate;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("ShipModule");
    }

    void Update()
    {
        _posX = _player.transform.position.x + Mathf.Cos(_angle) * _radius;
        _posz = _player.transform.position.z + Mathf.Sin(_angle) * _radius;

        transform.position = new Vector3(_posX, transform.position.y, _posz);
        _angle = _angle + Time.deltaTime * _angularSpeed;

        _transformRotate.Rotate(0, -_speedRotate * Time.deltaTime, 0);

        _angle = _angle % 360;
    }
}
