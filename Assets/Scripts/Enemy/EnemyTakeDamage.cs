using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{
    [SerializeField]
    private EnemyHealth _health;
    [SerializeField]
    private int _defaultBulletDamage;
    [SerializeField]
    private int _tankBulletDamage;
    [SerializeField]
    private int _flameDamage;
    [SerializeField]
    private int _airPlaneDamage;
    [SerializeField]
    private int _lightingDamage;


    private float _timeInterval;

    [SerializeField]
    private GameObject _damageUI;

    private void Start()
    {
        _timeInterval = Time.time;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            //_health.TakeDamage(DamageManager.DeafaultDamage());
            DispayDamgageTaken();
        }
    }

    public void DispayDamgageTaken()
    {
        GameObject takeDamageUI = Instantiate(_damageUI, gameObject.transform.position + new Vector3(0,1.5f,0), _damageUI.transform.rotation);
        Destroy(takeDamageUI, 0.5f);
    }
}
