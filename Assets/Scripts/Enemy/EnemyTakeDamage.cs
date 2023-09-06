using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{
    [SerializeField]
    private EnemyHealth _health;
    [SerializeField]
    private int _defaultBulletDamage;
    [SerializeField]
    private int _tankBulletDamage;
    [SerializeField]
    private int _flameDamage;
    [SerializeField]
    private int _airPlaneDamage;


    private float _timeInterval;
    

    private void Start()
    {
        _timeInterval = Time.time;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            _health.TakeDamage(_defaultBulletDamage);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("FlameCollider"))
        {
            if(Time.time - _timeInterval > 0.3f)
            {
                _health.TakeDamage(_flameDamage);
                _timeInterval = Time.time;
            }
        }
        if (other.gameObject.CompareTag("AirPlaneCollider"))
        {
            if (Time.time - _timeInterval > 0.3f)
            {
                _health.TakeDamage(_airPlaneDamage);
                _timeInterval = Time.time;
            }
        }
    }
}
