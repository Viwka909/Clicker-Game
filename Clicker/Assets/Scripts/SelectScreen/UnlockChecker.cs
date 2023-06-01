using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockChecker : MonoBehaviour
{
    [SerializeField]
    public GirlUnlockCheck Girl1;
    public GirlUnlockCheck Girl2;
    public GirlUnlockCheck Girl3;
    public GirlUnlockCheck Girl4;
    public GirlUnlockCheck End;
    public GameObject Event2;
    public GameObject Event3;
    public GameObject Event4;
    public GameObject EventEnd;
    public GirlData bar1;
    public GirlData bar2;
    public GirlData bar3;
    public GirlData bar4;
    void Start()
    {
        if (bar1.Value >= 187 && Girl2.Value == 0)
        {
            Event2.SetActive(true);
        }
        if (bar2.Value >= 240 && Girl3.Value == 0)
        {
            Event3.SetActive(true);
        }
        if (bar3.Value >= 330 && Girl4.Value == 0)
        {
            Event4.SetActive(true);
        }
        if(Girl1.Value == 2 && Girl2.Value == 2 && Girl3.Value == 2 && Girl4.Value == 2 && End.Value == 0){
            EventEnd.SetActive(true);
        }
    }
}
