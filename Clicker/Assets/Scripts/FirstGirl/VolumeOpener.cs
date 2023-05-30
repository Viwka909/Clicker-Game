using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class VolumeOpener : MonoBehaviour
{
    [SerializeField] GameObject Authors;
    public Button[] _buttons;
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
            Authors.SetActive(true);
            _state = false;
        }
        else if(_state == false)
        {
            foreach (Button button in _buttons)
            {
                button.interactable = true;
            }
            Authors.SetActive(false);
            _state = true;
        }

    }
     public void PanelClose()
    {
        if (_state == false && Input.GetKeyDown(KeyCode.Escape) )
        {
             foreach (Button button in _buttons)
            {
                button.interactable = true;
            }
            Authors.SetActive(false);
            _state = true;
        }
    }
}
