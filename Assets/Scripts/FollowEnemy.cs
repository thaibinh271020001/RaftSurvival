using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefabs;
    private float shootingInterval;
    [SerializeField]
    private float _distanceDetectionByPlayer;
    [SerializeField]
    private Transform _shootPoint;
    void Start()
    {
        shootingInterval = Time.time;
    }

    void Update()
    {
        DetectionByPlayer();
    }

    public void DetectionByPlayer()
    {
        float distanceClosest = Mathf.Infinity;
        EnemyMovement enemyClosest = null;
        EnemyMovement[] allEnemies = GameObject.FindObjectsOfType<EnemyMovement>();

        foreach(EnemyMovement currentEnemy in allEnemies)
        {
            float distanceEnemyToPLayer = (currentEnemy.transform.position - transform.position).magnitude;
            if (distanceEnemyToPLayer < distanceClosest)
            {
                distanceClosest = distanceEnemyToPLayer;
                enemyClosest = currentEnemy;
            }
        }

        if (enemyClosest != null)
        {
            float distance = Vector3.Distance(transform.position, enemyClosest.transform.position);
            if (distance < _distanceDetectionByPlayer && Time.time - shootingInterval > 0.65f)
            {
                Vector3 direction = enemyClosest.transform.position - transform.position;
                transform.rotation = Quaternion.LookRotation(direction, Vector3.up);

                Instantiate(_bulletPrefabs, _shootPoint.position, _shootPoint.rotation);
                shootingInterval = Time.time;
            }
        }
    }
}
