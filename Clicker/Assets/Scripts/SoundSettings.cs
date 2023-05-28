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
    private void FixedUpdate()
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
        else
        {
            _settingsButton.SetActive(false);
            _isEnabled = false;
        }
    }
}