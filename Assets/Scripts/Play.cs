using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _choosePlayer;
    [SerializeField]
    private GameObject _body; 

    [SerializeField]
    private GameObject _protect;

    public static bool isProtected = false;
    public static bool isFirstUnit = true;

    void Start()
    {
        VariableStatic.isMainRaft = true;
        PlayerPrefs.SetInt("IsStartGame", 1);

        if (PlayerPrefs.GetInt("CharacterSelection") == 1){
            Instantiate(_choosePlayer[0], _body.transform.parent);
        }else if(PlayerPrefs.GetInt("CharacterSelection") == 2)
        {
            Instantiate(_choosePlayer[1], _body.transform.parent);
        }else if(PlayerPrefs.GetInt("CharacterSelection") == 3)
        {
            Instantiate(_choosePlayer[2], _body.transform.parent);
        }else if(PlayerPrefs.GetInt("CharacterSelection") == 4)
        {
            Instantiate(_choosePlayer[3], _body.transform.parent);
        }else if(PlayerPrefs.GetInt("CharacterSelection") == 5)
        {
            Instantiate(_choosePlayer[4], _body.transform.parent);
        }else if(PlayerPrefs.GetInt("CharacterSelection") == 6)
        {
            Instantiate(_choosePlayer[5], _body.transform.parent);
        }else if(PlayerPrefs.GetInt("CharacterSelection") == 7)
        {
            Instantiate(_choosePlayer[6], _body.transform.parent);
        }

    }

    private void Update()
    {
        if(isProtected == true)
        {
            _protect.SetActive(true);
        }
        else
        {
            _protect.SetActive(false);
        }

        
    }
}
