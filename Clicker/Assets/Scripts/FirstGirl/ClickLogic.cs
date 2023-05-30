using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickLogic : MonoBehaviour
{
    [SerializeField] public int _hearts = 0;
    [SerializeField] GiftButton _giftButton1;
    [SerializeField] GiftButton _giftButton2;
    public int clickcounter = 0;
    public GirlData hrtval;
    
    public Text HeartsValue;
    public int ClickValue;
    

    public void OnClick()
    {
        _hearts +=  ClickValue;
        hrtval.Value += ClickValue;
        HeartsValue.text  =  _hearts.ToString(); 
        //Debug.Log("123");

        if (_giftButton1.ClickCount > 0)
        {
            _giftButton1.ClickCount--;
            Debug.Log($"Super clicks count is - {_giftButton1.ClickCount}");
        }
        if (_giftButton1.IsBought == true && _giftButton1.ClickCount == 0)
        {
            ClickValue = 1;
            _giftButton1.IsBought = false;
        }

        if (_giftButton2.ClickCount > 0)
        {
            _giftButton2.ClickCount--;
            Debug.Log($"Super clicks count is - {_giftButton2.ClickCount}");
        }
        if (_giftButton2.IsBought == true && _giftButton2.ClickCount == 0)
        {
            ClickValue = 1;
            _giftButton2.IsBought = false;
        }
    }
     void Start()
    {
        _giftButton1.ClickCount = 0;
        _giftButton2.ClickCount = 0;
        ClickValue = 1;
        _hearts = hrtval.Value;
        HeartsValue.text  =  _hearts.ToString();
        Debug.Log(ClickValue);
     }
}
