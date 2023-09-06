using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private float _health;

    [SerializeField]
    private GameObject _experience;
    [SerializeField]
    private GameObject _skull;

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
        Experience();
        SkullAnimation();
        Destroy(gameObject);
    }

    public void Experience()
    {
        _experience.SetActive(true);
        _experience.transform.position = transform.position + new Vector3(0, 0.37f, 0);
    }

    public void SkullAnimation()
    {
        Instantiate(_skull, gameObject.transform.position + new Vector3(0,1.25f,0), _skull.transform.rotation);
    }
}
