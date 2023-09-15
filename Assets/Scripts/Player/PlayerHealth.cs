using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    public float _health;
    public float _currentHealth;

    [SerializeField]
    private Slider _sliderHealthBar;
    [SerializeField]
    private GameObject _HealthBar;

    private Coroutine _healthBarCoroutine;

    public static bool IsDie = false;

    public static bool thrusterIsDie;

    private void Start()
    {
        _currentHealth = _health;
    }

    private void Update()
    {
        _sliderHealthBar.value = _currentHealth / _health;   
    }

    public void TakeDamage(float damage)
    {
        Debug.Log("abc");
        _currentHealth -= damage;

        if (_currentHealth <= 0)
        {
            Die();
        }

        ShowHealthBar();
    }

    public void ShowHealthBar()
    {
        if (_healthBarCoroutine != null)
        {
            StopCoroutine(_healthBarCoroutine);
        }

        _healthBarCoroutine = StartCoroutine(DisplayHealthBarForDuration());
    }

    private IEnumerator DisplayHealthBarForDuration()
    {
        _HealthBar.SetActive(true);
        yield return new WaitForSeconds(2f);

        _HealthBar.SetActive(false);

    }


    private void Die()
    {


        //IsDie = true;
        //Time.timeScale = 0;
        //Destroy(gameObject);
    }
}
