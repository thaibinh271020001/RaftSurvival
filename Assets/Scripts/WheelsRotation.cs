using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelsRotation : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement _playerMovement;

    // Update is called once per frame
    void Update()
    {
        Vector3 directionRotate = _playerMovement.diretion;
        if (directionRotate != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(directionRotate, Vector3.up);
        }
    }
}
