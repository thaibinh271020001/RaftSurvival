using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    private GameObject enemy;
    private bool _detection = true;

    [SerializeField]
    private float _speedBullet;
    private void Update()
    {
        FindClosestEnemy();
    }

    public void FindClosestEnemy()
    {
        if (_detection == true)
        {
            GameObject player = GameObject.Find("ShootPoint");

            float distanceTocloseEnemy = Mathf.Infinity;
            EnemyMovement closestEnemies = null;
            EnemyMovement[] allEnenies = GameObject.FindObjectsOfType<EnemyMovement>();
            foreach (EnemyMovement currentEnemy in allEnenies)
            {
                float distanceToEnemy = (currentEnemy.transform.position - player.transform.position).magnitude;
                if (distanceToEnemy < distanceTocloseEnemy)
                {
                    distanceTocloseEnemy = distanceToEnemy;
                    closestEnemies = currentEnemy;
                }
            }

            Vector3 directionRotation = closestEnemies.transform.position - player.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, closestEnemies.transform.position, _speedBullet);
            transform.rotation = Quaternion.LookRotation(directionRotation, Vector3.up);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            _detection = false;
        }
    }
}