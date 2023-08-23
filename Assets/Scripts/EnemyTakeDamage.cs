using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{
    [SerializeField]
    private EnemyHealth _health;
    [SerializeField]
    private int _defaultBulletDamage;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            _health.TakeDamage(_defaultBulletDamage);
        }
    }
}
