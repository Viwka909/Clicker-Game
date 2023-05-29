using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickLogic : MonoBehaviour
{
    [SerializeField] public int _hearts = 0;
    public int clickcounter = 0;
    public GirlData hrtval;
    
    public Text HeartsValue;
    public int ClickValue;
    

    public void OnClick()
    {
        _hearts +=  ClickValue;
        hrtval.Value += ClickValue;
        HeartsValue.text  =  _hearts.ToString(); 
        Debug.Log("123");
    }
     void Start()
    {
        ClickValue = 1;
         _hearts = hrtval.Value;
         HeartsValue.text  =  _hearts.ToString();
        Debug.Log(ClickValue);
    }
}
