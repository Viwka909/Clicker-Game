using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GiftButton : MonoBehaviour
{
        [SerializeField]
         public int _ButtonValue;
         public GirlData barvalue;
         public GirlData hrtval;
    [SerializeField] private ClickLogic _clickLogic;
    

    public void OnClick()
    {

        ProgBar Pbar = FindObjectOfType<ProgBar>();
        int init = FindObjectOfType<ProgBar>().current;
        ClickLogic counter = FindObjectOfType<ClickLogic>();
        int hearts = FindObjectOfType<ClickLogic>()._hearts;
        Text HeartsValue = FindObjectOfType<ClickLogic>().HeartsValue;
       
        if (hearts >= _ButtonValue)
        {
            _clickLogic.ClickValue += 1;
            Debug.Log("Click value increased");
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
