using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    [SerializeField]
    private GameObject _setting;
    
    [SerializeField]
    private GameObject _menu;
    [SerializeField]
    private GameObject _shop;

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
        SceneManager.LoadScene(1);
    }

    public void CloseButtonInMenu()
    {
        _setting.SetActive(false);
    }

    public void CloseButtonShopToMenu()
    {
        _shop.SetActive(false);
        _menu.SetActive(true);
    }
    public void CloseButtonMenuToShop()
    {
        _shop.SetActive(true);
        _menu.SetActive(false);
    }
}
