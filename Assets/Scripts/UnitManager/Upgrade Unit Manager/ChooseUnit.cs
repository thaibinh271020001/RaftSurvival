using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseUnit : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }

    private void FixedUpdate()
    {
        if (VariableStatic.CanChoose == false)
        {
            Time.timeScale = 0;
        }
    }

    private void OnMouseDown()
    {
        if(VariableStatic._unitPrefab != null)
        {
            Instantiate(VariableStatic._unitPrefab, gameObject.transform.position, transform.rotation, gameObject.transform.parent);
            Time.timeScale = 1f;
        }
        LevelManager.isUpgrade = false;
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        VariableStatic.CanChoose = true;
        Time.timeScale = 1f;
        if (other.CompareTag("ShipModule"))
        {
            Destroy(gameObject);
        }

        VariableStatic.CanChoose = false;
    }
}
