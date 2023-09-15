using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    [SerializeField]
    private float _radius;
    [SerializeField]
    private GameObject _magnet;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ShipModule"))
        {
            Destroy(gameObject);
            
        }
    }
}
