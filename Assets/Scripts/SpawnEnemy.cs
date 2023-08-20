using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private float shootingInterval;
    [SerializeField]
    private GameObject _enemyPrefabs;
    private Vector3 spawnEnemy;

    void Start()
    {
        shootingInterval = Time.time;
        spawnEnemy = new Vector3(0, -0.1f, 25f);
    }

    void Update()
    {
        InstancetiateEnemy();
    }

    public void InstancetiateEnemy()
    {
        if (Time.time - shootingInterval > 3f)
        {
            Instantiate(_enemyPrefabs, spawnEnemy, _enemyPrefabs.transform.rotation);
            shootingInterval = Time.time;
        }
    }
}
