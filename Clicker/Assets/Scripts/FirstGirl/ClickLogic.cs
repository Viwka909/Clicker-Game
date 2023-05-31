using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickLogic : MonoBehaviour
{
    [SerializeField] public int _hearts = 0;

    public int clickcounter = 0;
    public Animator Stroke;
    
    public GirlData hrtval;
    public int modifier = 1;
    public Text HeartsValue;
    public GameObject StrokeObject;
    

    public void OnClick()
    {
        StrokeObject.SetActive(true);
        Stroke.SetTrigger("Click");
        Debug.Log(modifier);
        _hearts += 1 * modifier;
        hrtval.Value += 1 * modifier;
        HeartsValue.text  =  _hearts.ToString(); 
    }
     void Start()
    {
         _hearts = hrtval.Value;
         HeartsValue.text  =  _hearts.ToString(); 
    }
}
