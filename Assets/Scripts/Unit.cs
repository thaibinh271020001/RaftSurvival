using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public void ExpandUnit()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
