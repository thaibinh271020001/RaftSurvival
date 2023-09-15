using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlaneDamage : MonoBehaviour
{
    private float _timeInterval;
    [SerializeField]
    private GameObject _damageUI;

    [SerializeField]
    private CheckLevelDamgeAirUnit _checkLevelDamgeAirUnit;

    private void Start()
    {
        _timeInterval = Time.time;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && Time.time - _timeInterval > 0.3f)
        {
            EnemyHealth dealDamageForEnemy = other.GetComponent<EnemyHealth>();
            dealDamageForEnemy.TakeDamage(DamageManager.AirPlaneDamage()*_checkLevelDamgeAirUnit.ecreaseDamage*DamageUnit.damageIncreaseByAttckUnit);

            GameObject takeDamageUI = Instantiate(_damageUI, other.transform.position + new Vector3(0, 1.5f, 0), _damageUI.transform.rotation);
            Destroy(takeDamageUI, 0.5f);
            _timeInterval = Time.time;
        }
    }
}
