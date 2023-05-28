using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataUpload : MonoBehaviour
{
    public GirlData hrtval;
    public Text HeartsValue;
    void Start()
    {
        HeartsValue.text  =  hrtval.Value.ToString(); 
    }
}

