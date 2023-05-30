using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class AuthorsButton : MonoBehaviour
{
    [SerializeField] GameObject Authors;
    GameObject[] _buttons;
    bool _state = true;
    private void Start()
    {
        _buttons = GameObject.FindGameObjectsWithTag("ScreenButton").ToArray();
    }

    public void OnClick()
    {
        if (_state == true)
        {
            foreach (GameObject button in _buttons)
            {
                button.SetActive(false);
            }
            Authors.SetActive(true);
            _state = false;
        }
        else
        {
            foreach (GameObject button in _buttons)
            {
                button.SetActive(true);
            }
            Authors.SetActive(false);
            _state = true;
        }

    }
}
