using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCuter : MonoBehaviour
{
    [SerializeField]
    private Animation _anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tree"))
        {
            _anim.Play();
            Destroy(other.gameObject);
        }
    }
}
