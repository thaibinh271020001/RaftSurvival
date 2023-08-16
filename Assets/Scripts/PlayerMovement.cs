using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Joystick _joystick;
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;
    public  Vector3 diretion;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();   
    }

    void Update()
    {
        float hInput = _joystick.Horizontal;
        float vInput = _joystick.Vertical;

        diretion = new Vector3(hInput, 0, vInput);
        _rigidbody.velocity = diretion*_speed; 
    }
}
