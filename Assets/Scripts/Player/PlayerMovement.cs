using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private FloatingJoystick _floatingJoystick;
    
    public float _speed;
    private Rigidbody _rigidbody;
    public  Vector3 diretion;

    [SerializeField]
    private float pushForce; 
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();   
    }

    void Update()
    {
        float hInput = _floatingJoystick.Horizontal;
        float vInput = _floatingJoystick.Vertical;

        diretion = new Vector3(hInput, 0, vInput);
        _rigidbody.velocity = diretion*_speed; 
    }
}
