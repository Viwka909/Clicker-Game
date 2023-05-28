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
    public GameObject Girl2Bar;
    public GameObject Girl2Heart;
    public Button Girl3Button1;
    public Button Girl3Button2;
    public GameObject Girl3Bar;
    public GameObject Girl3Heart;
    public Button Girl4Button1;
    public Button Girl4Button2;
    public GameObject Girl4Bar;
    public GameObject Girl4Heart;
    void Start()
    {
        if (bar1.Value >= 50)
        {
            Girl2Button1.interactable = true;
            Girl2Button2.interactable = true;
            Girl2Bar.SetActive(true);
            Girl2Heart.SetActive(true);
        }
        if (bar2.Value >= 50)
        {
            Girl3Button1.interactable = true;
            Girl3Button2.interactable = true;
            Girl3Bar.SetActive(true);
            Girl3Heart.SetActive(true);
        }
         if (bar3.Value >= 50)
        {
            Girl4Button1.interactable = true;
            Girl4Button2.interactable = true;
            Girl4Bar.SetActive(true);
            Girl4Heart.SetActive(true);
        }
    }

}
