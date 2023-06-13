using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondGirlChecker : MonoBehaviour
{
    public GirlUnlockCheck Girl1;
    public GirlUnlockCheck Girl2;
    public GirlUnlockCheck Girl3;
    public GirlUnlockCheck Girl4;
    public GirlUnlockCheck End;
    public GirlData bar;
    public GameObject Event;

    void Update()
    {
        if (bar.Value >= 260 && Girl3.Value == 0)
        {
            Event.SetActive(true);
        }
        if(bar.Value >= 520 && Girl2.Value != 2){
            Girl2.Value = 2;
        }
        if(Girl1.Value == 2 && Girl2.Value == 2 && Girl3.Value == 2 && Girl4.Value == 2 && End.Value == 0){
            Event.SetActive(true);
        }
    }
}
