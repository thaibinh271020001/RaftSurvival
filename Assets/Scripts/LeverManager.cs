using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeverManager : MonoBehaviour
{
    [SerializeField]
    private Slider _levelBar;
    [SerializeField]
    private Text _levelText;
    private float _currentLevel = 1;
    private float _pointExperience = 0;
    private float _maxLevelUpExperience = 100;
    private float _experienceIncrease = 1.1f;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Experience")
        {
            _pointExperience += 10;
            _levelBar.value = _pointExperience / _maxLevelUpExperience;

            if (_pointExperience >= _maxLevelUpExperience)
            {
                _levelBar.value = 0;
                _pointExperience = 0;
                _currentLevel++;
                _maxLevelUpExperience *= _experienceIncrease;
                _levelText.text = "" + _currentLevel;
            }
        }

    }
}
