using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstGirlChecker : MonoBehaviour
{
    public GirlUnlockCheck Girl1;
    public GirlUnlockCheck Girl2;
    public GirlUnlockCheck Girl3;
    public GirlUnlockCheck Girl4;
    public GirlUnlockCheck End;
    public GirlData bar;
    public GameObject Tutor;
    public GameObject Event;

    void Start()
    {
        if (Girl1.Value == 0)
        {
            Girl1.Value++;
            Tutor.SetActive(true);
        }
    }
    void Update()
    {
        if (bar.Value >= 50 && Girl2.Value == 0)
        {
            Event.SetActive(true);
        }
        if(bar.Value >= 100 && Girl1.Value != 2){
            Girl1.Value = 2;
        }
        if(Girl1.Value == 2 && Girl2.Value == 2 && Girl3.Value == 2 && Girl4.Value == 2 && End.Value == 0){
            Event.SetActive(true);
        }
        
    }
}
