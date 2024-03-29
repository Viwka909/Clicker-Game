using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;


public class GiftButton : MonoBehaviour
{
    [SerializeField]
    public  GameObject Girl;
    public  Sprite HappyState;
    public Sprite SadState;
    public Sprite NormalState;
    public int _ButtonCost;
    public int _ButtonValue;
    public GirlData barvalue;
    public GirlData hrtval;
    public bool buffable;
    public bool badgift;
    public int modifier = 2;
    public float timerDuration = 10;
    public void OnClick()
    {
        ProgBar Pbar = FindObjectOfType<ProgBar>();
        int init = FindObjectOfType<ProgBar>().current;
        ClickLogic counter = FindObjectOfType<ClickLogic>();
        int hearts = FindObjectOfType<ClickLogic>()._hearts;
        TextMeshProUGUI HeartsValue = FindObjectOfType<ClickLogic>().HeartsValue;
        Timer timer =FindObjectOfType<Timer>();

        if (hearts >= _ButtonCost)
        {
            hearts -= _ButtonCost;
            counter._hearts -= _ButtonCost;
            HeartsValue.text = hearts.ToString();
            Pbar.current = init + _ButtonValue;
            barvalue.Value += _ButtonValue;
            hrtval.Value -= _ButtonCost;
            PlayerPrefs.SetInt(hrtval.ToString(), hrtval.Value);
            PlayerPrefs.SetInt(barvalue.ToString(), hrtval.Value);
            
        }
        if (buffable == true)
        {
            counter.modifier = modifier;
            timer.TimeLeft += timerDuration;
            timer.TimerOn = true;
            Girl.GetComponent<Image>().sprite = HappyState;
        }
        if (badgift == true)
        {
            Girl.GetComponent<Image>().sprite = SadState;
            Invoke("RevertState",5f);
        }   
    }
    public void RevertState(){
        Girl.GetComponent<Image>().sprite = NormalState;
    }
}

