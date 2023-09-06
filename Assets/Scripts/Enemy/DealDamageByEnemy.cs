using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamageByEnemy : MonoBehaviour
{
    private PlayerHealth _playerHealth;
    [SerializeField]
    private int _damage;
    private float _timeInterval;

    private void Start()
    {
        _playerHealth = GameObject.Find("SoldierModule").GetComponent<PlayerHealth>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "SoldierModule" && Time.time - _timeInterval > 1f)
        {
            _playerHealth.TakeDamage(_damage);
            _timeInterval = Time.time;
        }
    }
}
