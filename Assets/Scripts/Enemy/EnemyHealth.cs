using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private float _health;

    [SerializeField]
    private GameObject _experience;
    [SerializeField]
    private GameObject _skull;
    [SerializeField]
    private GameObject _enemy;

    public static float _damgeTaken;

    public void TakeDamage(float damage)
    {
        _health -= damage;

        Debug.Log(damage);
        _damgeTaken = damage;
        Debug.Log(_health);
        if(_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Instantiate(_experience, gameObject.transform.position + new Vector3(0, 0.37f, 0), _experience.transform.rotation);
        Instantiate(_skull, gameObject.transform.position + new Vector3(0, 1.25f, 0), _skull.transform.rotation);
        Destroy(_enemy);
    }
}
