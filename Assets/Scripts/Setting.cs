using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    [SerializeField]
    private GameObject _setting;

    public void SettingOn()
    {
        _setting.SetActive(true);
        Time.timeScale = 0f;
    }
    public void SettingOff()
    {
        _setting.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
