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

    [SerializeField]
    private float pushForce; 
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

    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.CompareTag("Enemy"))
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            
            if(enemyRigidbody != null)
            {
                Vector3 pushDirection = collision.contacts[0].point - transform.position;
                enemyRigidbody.AddForce(pushDirection * pushForce,ForceMode.Impulse);
            }
        }*/
    }
}
