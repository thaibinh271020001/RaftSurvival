using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefab;
    private GameObject _enemy;
    [SerializeField]
    private Transform _shootPoint;
    void Start()
    {
        _enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Instantiate(_bulletPrefab, _shootPoint.position, _shootPoint.rotation);
        }
    }
}
