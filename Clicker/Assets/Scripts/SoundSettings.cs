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
    private void Update()
    {
        PanelClose();
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
    }
    private void PanelClose()
    {
        if (_isEnabled == true && Input.GetKeyDown(KeyCode.Escape) )
        {
            _settingsButton.SetActive(false);
            _isEnabled = false;
        }
    }

}