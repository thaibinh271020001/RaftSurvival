using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour
{
    [SerializeField]
    private GameObject _flamePlace;
    private float _distance;

    ClosestEnemy closestEnemy;
    private void Start()
    {
        closestEnemy = GameObject.FindObjectOfType<ClosestEnemy>();
    }

    private void Update()
    {
        if(closestEnemy != null)
        {
            _distance = closestEnemy.DetectionByPlayer(gameObject.transform);
            if (_distance < 7.5f)
            {
                ActiveFlame();
            }
            else
            {
                DisableFlame();
            }
        }
        
    }

    public void ActiveFlame()
    {
        _flamePlace.SetActive(true);
    }
    public void DisableFlame()
    {
        _flamePlace.SetActive(false);
    }
}
