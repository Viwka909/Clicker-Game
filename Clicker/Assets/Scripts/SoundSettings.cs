using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    [SerializeField] private GameObject _settingsButton;
    private bool _isEnabled = false;
    Button[] _buttons;

    private void Start()
    {
        _buttons = GameObject.FindGameObjectsWithTag("ScreenButton").Select(obj => obj.GetComponent<Button>()).ToArray();
    }
    private void Update()
    {
        PanelClose();
    }
    public void SoundSettingsPanel()
    {
        if (_isEnabled == false)
        {
            _settingsButton.SetActive(true);
            foreach (Button button in _buttons)
            {
                button.interactable = false;
            }
            _isEnabled = true;
        }
        else if (_isEnabled == true) 
        {
            _settingsButton.SetActive(false);
            foreach (Button button in _buttons)
            {
                button.interactable = true;
            }
            _isEnabled = false;
        }
    }
    private void PanelClose()
    {
        if (_isEnabled == true && Input.GetKeyDown(KeyCode.Escape) )
        {
            _settingsButton.SetActive(false);
            foreach (Button button in _buttons)
            {
                button.interactable = true;
            }
            _isEnabled = false;
        }
    }

}