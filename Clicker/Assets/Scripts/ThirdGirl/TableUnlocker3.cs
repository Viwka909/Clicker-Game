using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TableUnlocker3 : MonoBehaviour
{
    public GirlData barprog;
    public TextMeshProUGUI _unlock1;
    public TextMeshProUGUI _unlock2;
    public TextMeshProUGUI _unlock3;
    public TextMeshProUGUI _unlock4;
    public TextMeshProUGUI _unlock5;
    public TextMeshProUGUI _unlock6;
    public TextMeshProUGUI _unlock7;
    public TextMeshProUGUI _unlock8;
    void Start()
    {

    }
    void Update()
    {
        if (barprog.Value >= 20)
        {
            _unlock1.text = "Красный и Золотой";
            _unlock2.text = "Жаренные грибы";
        }
        if (barprog.Value >= 40)
        {
            _unlock3.text = "Воровать";
            _unlock4.text = "За любовь плати любовью, за измену кровью.";
        }
        if (barprog.Value >= 60)
        {
            _unlock5.text = "Розовый";
            _unlock6.text = "Лобстеры";
        }
        if (barprog.Value >= 80)
        {
            _unlock7.text = "170 см";
            _unlock8.text = "65 кг";
        }
    }
}
