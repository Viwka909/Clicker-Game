using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class VolumeOpener : MonoBehaviour
{
    [SerializeField] GameObject Window;
    public Button[] _buttons;
    public AudioData _MasterVol;
    public AudioData _MusicVol;
    public AudioData _SFXVol;
    public bool _state = true;
    private void Start()
    {
        _buttons = GameObject.FindGameObjectsWithTag("ScreenButton").Select(obj => obj.GetComponent<Button>()).ToArray();
    }
    private void Update()
    {
        PanelClose();
    }

    public void OnClick()
    {
        if (_state == true)
        {
            foreach (Button button in _buttons)
            {
                button.interactable = false;
            }
            Window.SetActive(true);
            _state = false;
        }
        else if(_state == false)
        {
            PlayerPrefs.GetFloat(_MasterVol.ToString(),_MasterVol.Value);
            PlayerPrefs.GetFloat(_MusicVol.ToString(),_MusicVol.Value);
            PlayerPrefs.GetFloat(_SFXVol.ToString(),_SFXVol.Value);
            foreach (Button button in _buttons)
            {
                button.interactable = true;
            }
            Window.SetActive(false);
            _state = true;
        }

    }
     public void PanelClose()
    {
        if (_state == false && Input.GetKeyDown(KeyCode.Escape) )
        {
            PlayerPrefs.GetFloat(_MasterVol.ToString(),_MasterVol.Value);
            PlayerPrefs.GetFloat(_MusicVol.ToString(),_MusicVol.Value);
            PlayerPrefs.GetFloat(_SFXVol.ToString(),_SFXVol.Value);
             foreach (Button button in _buttons)
            {
                button.interactable = true;
            }
            Window.SetActive(false);
            _state = true;
        }
    }
}
