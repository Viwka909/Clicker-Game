using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GirlUnlocker : MonoBehaviour
{
    [SerializeField]
    public GirlData bar1;
    public GirlData bar2;
    public GirlData bar3;
    public Button Girl2Button1;
    public Button Girl3Button1;
    public Button Girl4Button1;
    public GameObject Girl2;
    public GameObject Girl3;
    public GameObject Girl4;
   
   
    void Start()
    {
        if (bar1.Value >= 187)
        {
            Girl2Button1.interactable = true;
            Girl2.tag = "ScreenButton";
        }
        if (bar2.Value >= 260)
        {
            Girl3Button1.interactable = true;
            Girl3.tag = "ScreenButton";
        }
        if (bar3.Value >= 330)
        {
            Girl4Button1.interactable = true;
            Girl4.tag = "ScreenButton";
        }
    }

}
