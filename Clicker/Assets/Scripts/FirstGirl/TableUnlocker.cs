using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TableUnlocker : MonoBehaviour
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
    void Update()
    {
        if (barprog.Value >= 75)
        {
            _unlock1.text = "Голубой";
            _unlock2.text = "Трехцветное Данго";
        }
        if (barprog.Value >= 150)
        {
            _unlock3.text = "Пение";
            _unlock4.text = "Если кто-то скажет что надеятся глупо, я отвечу, что это не правда.";
        }
        if (barprog.Value >= 225)
        {
            _unlock5.text = "Серый";
            _unlock6.text = "Устрицы";
        }
        if (barprog.Value >= 300)
        {
            _unlock7.text = "160 см";
            _unlock8.text = "50 кг";
        }
    }
}
