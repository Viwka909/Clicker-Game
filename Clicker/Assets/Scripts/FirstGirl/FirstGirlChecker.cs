using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstGirlChecker : MonoBehaviour
{
    public GirlUnlockCheck Girl1;
    public GirlUnlockCheck Girl2;
    public GirlUnlockCheck Girl3;
    public GirlUnlockCheck Girl4;
    public GirlData bar;
    public GameObject Tutor;
    public GameObject Event;

    void Start()
    {
        if(Girl1.Value == 0){
            Girl1.Value++;
            Tutor.SetActive(true);
        }
    }
    void Update()
    {

    }
}
