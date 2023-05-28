using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GiftButton2 : MonoBehaviour
{
        [SerializeField]
         public int _ButtonValue;
         public GirlData barvalue;
         public GirlData hrtval;
    
    public void OnClick()
    {
        ProgBar2 Pbar = FindObjectOfType<ProgBar2>();
        int init = FindObjectOfType<ProgBar2>().current;
        ClickLogic2 counter = FindObjectOfType<ClickLogic2>();
        int hearts = FindObjectOfType<ClickLogic2>()._hearts;
        Text HeartsValue = FindObjectOfType<ClickLogic2>().HeartsValue;
       
        if (hearts >= _ButtonValue)
        {
            hearts -= _ButtonValue;
            counter._hearts-=_ButtonValue;
            HeartsValue.text = hearts.ToString();
            Pbar.current = init + _ButtonValue;
            barvalue.Value += _ButtonValue;
            hrtval.Value -= _ButtonValue;

        }
        Debug.Log("Pressed");
        Debug.Log(_ButtonValue);
    }
}
