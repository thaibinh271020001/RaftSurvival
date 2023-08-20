using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    private GameObject enemy;
    [SerializeField]
    private float _speed;

    /*void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }*/

    void Update()
    {
        /*GameObject player = GameObject.Find("ShootPoint");

        Vector3 directionRotation = enemy.transform.position - player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, enemy.transform.position, 0.05f);
        transform.rotation = Quaternion.LookRotation(directionRotation, Vector3.up);*/

        FindClosestEnemy();
    }

    public void FindClosestEnemy()
    {
        GameObject player = GameObject.Find("ShootPoint");
        float distanceToClosestEnemy = Mathf.Infinity;
        EnemyMovement closestEnemies = null;
        EnemyMovement[] allEnemies = GameObject.FindObjectsOfType<EnemyMovement>();

        foreach(EnemyMovement currentEnemy in allEnemies)
        {
            float distanceToEnemy = (currentEnemy.transform.position - player.transform.position).sqrMagnitude;
            if(distanceToEnemy < distanceToClosestEnemy)
            {
                distanceToClosestEnemy = distanceToEnemy;
                closestEnemies = currentEnemy;
            }
        }

        Vector3 directionRotation = closestEnemies.transform.position - player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, closestEnemies.transform.position, 0.05f);
        transform.rotation = Quaternion.LookRotation(directionRotation, Vector3.up);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
