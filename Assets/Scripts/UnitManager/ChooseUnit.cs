using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseUnit : MonoBehaviour
{
    [SerializeField]
    private GameObject _tankModule;
    [SerializeField]
    private GameObject _turretModule;
    [SerializeField]
    private GameObject _flameModule;
    [SerializeField]
    private GameObject _airPlaneModule;
    [SerializeField]
    private GameObject _forwardRocketModule;

    private void OnMouseDown()
    {
        InstancetiateTurretRocketModule(gameObject);
        LevelManager.isUpgrade = false;
        Destroy(gameObject);
    }

    public void InstancetiateTankModule(GameObject tankTranform)
    {
        Instantiate(_tankModule, tankTranform.transform.position, transform.rotation, gameObject.transform.parent);
        Time.timeScale = 1;
    }
    public void InstancetiateTurretModule(GameObject tankTranform)
    {
        Instantiate(_turretModule, tankTranform.transform.position, transform.rotation, gameObject.transform.parent);
        Time.timeScale = 1;
    }
    public void InstancetiateFlameThrowerModule(GameObject tankTranform)
    {
        Instantiate(_flameModule, tankTranform.transform.position, transform.rotation, gameObject.transform.parent);
        Time.timeScale = 1;
    }
    public void InstancetiateAirPlaneModule(GameObject tankTranform)
    {
        Instantiate(_airPlaneModule, tankTranform.transform.position, transform.rotation, gameObject.transform.parent);
        Time.timeScale = 1;
    }
    public void InstancetiateTurretRocketModule(GameObject tankTranform)
    {
        Instantiate(_forwardRocketModule, tankTranform.transform.position, transform.rotation, gameObject.transform.parent);
        Time.timeScale = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name);

        if (other.CompareTag("ShipModule"))
        {
            Destroy(gameObject);
        }

        Time.timeScale = 0;
    }
}
