using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    [SerializeField] private GameObject _settingsButton;
    [SerializeField] private Button _button;
    private bool _isEnabled = false;
    private void Start()
    {
        _button.onClick.AddListener(SoundSettingsPanel);
    }
    private void SoundSettingsPanel()
    {
        if (_isEnabled == false)
        {
            _settingsButton.SetActive(true);
            _isEnabled = true;
        }
        else if (_isEnabled == true) 
        {
            _settingsButton.SetActive(false);
            _isEnabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _isEnabled == true)
        {
            _settingsButton.SetActive(false);
            _isEnabled = false;
        }
    }
}