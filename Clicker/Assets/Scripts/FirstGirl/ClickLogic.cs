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
    

    public void OnClick()
    {
        _hearts++;
        hrtval.Value += 1;
        HeartsValue.text  =  _hearts.ToString(); 
        Debug.Log("123");
    }
     void Start()
    {
         _hearts = hrtval.Value;
         HeartsValue.text  =  _hearts.ToString(); 
    }
}
