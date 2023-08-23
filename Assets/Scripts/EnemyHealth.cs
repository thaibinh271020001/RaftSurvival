using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private float _health;

    [SerializeField]
    private GameObject _experience;

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if(_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        _experience.SetActive(true);
        _experience.transform.position = transform.position + new Vector3(0,0.37f,0);
        Destroy(gameObject);
    }
}