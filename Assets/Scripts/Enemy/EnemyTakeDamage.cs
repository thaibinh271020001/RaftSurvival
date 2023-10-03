using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{
    [SerializeField]
    private GameObject _damageUI;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            DispayDamgageTaken();
        }
    }

    public void DispayDamgageTaken()
    {
        GameObject takeDamageUI = Instantiate(_damageUI, gameObject.transform.position + new Vector3(0,2f,0), _damageUI.transform.rotation);
        Destroy(takeDamageUI, 1f);
    }
}
