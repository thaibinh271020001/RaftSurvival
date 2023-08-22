using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private float _timeInterval;
    [SerializeField]
    private GameObject Player;
    
    [SerializeField]
    private GameObject _enemyPrefabs;

    void Start()
    {
        _timeInterval = Time.time;
    }

    void Update()
    {
        InstancetiateEnemy();
    }

    public void InstancetiateEnemy()
    {
        if (Time.time - _timeInterval > 1.5f)
        {
            Vector3 offset = Random.onUnitSphere;
            if ((offset.x > 0.5 || offset.x <-0.5) && (offset.z > 0.5||offset.z <-0.5))
           {
                offset.y = 0;
                Vector3 newOffset = transform.position + offset * Random.Range(15.2f, 15.20001f);

                Debug.Log(offset);

                Instantiate(_enemyPrefabs, newOffset, _enemyPrefabs.transform.rotation);
                _timeInterval = Time.time;
            }
        }
    }
}
