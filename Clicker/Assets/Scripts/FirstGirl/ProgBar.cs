using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ExecuteInEditMode]
public class ProgBar : MonoBehaviour
{

    public int maximum = 100;
    [SerializeField] private FirstGirlData barvalue;
    public int current;
    public Image Mask;
    
    void Start()
    {
        current = barvalue.Value;
    }
    void Update()
    {
        GetCurrFill();
    }
    public void GetCurrFill( )
    {
        float FillAmount = (float)current / (float)maximum;
        Mask.fillAmount = FillAmount;
    }
}
