using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class TableOpener : MonoBehaviour
{
    [SerializeField]GameObject Table;

    Button[] _buttons;
    private void Start()
    {
        _buttons = GameObject.FindGameObjectsWithTag("ScreenButton").Select(obj => obj.GetComponent<Button>()).ToArray();
    }
    public void OnClick()
    {
        foreach (Button button in _buttons)
        {
            button.interactable = false;
        }
        Table.SetActive(true);
    }
}
