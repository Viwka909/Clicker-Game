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
    public Button Girl2Button2;
    public Button Girl3Button1;
    public Button Girl3Button2;
    public Button Girl4Button1;
    public Button Girl4Button2;
       void Start()
    {
        if (bar1.Value >= 187)
        {
            Girl2Button1.interactable = true;
            
        }
        if (bar2.Value >= 50)
        {
            Girl3Button1.interactable = true;         
        }
         if (bar3.Value >= 330)
        {
            Girl4Button1.interactable = true;
        }
    }

}
