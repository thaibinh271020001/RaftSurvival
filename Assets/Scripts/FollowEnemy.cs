using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    private GameObject targetEnemy;

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
        targetEnemy = GameObject.Find("TargetPoint");
        DetectionByPlayer();
    }

    public void DetectionByPlayer()
    {
        if (targetEnemy!=null)
        {
            float distance = Vector3.Distance(transform.position, targetEnemy.transform.position);
            if (distance < _distanceDetectionByPlayer && Time.time - shootingInterval > 2f)
            {
                Vector3 direction = targetEnemy.transform.position - transform.position;
                transform.rotation = Quaternion.LookRotation(direction, Vector3.up);

                Instantiate(_bulletPrefabs, _shootPoint.position, _shootPoint.rotation);
                shootingInterval = Time.time;
            }
        }
    }
}
