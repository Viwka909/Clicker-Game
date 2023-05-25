using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TableUnlocker4 : MonoBehaviour
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
            _unlock1.text = "Черный";
            _unlock2.text = "Стейк с кровью";
        }
        if (barprog.Value >= 40)
        {
            _unlock3.text = "Дуэли";
            _unlock4.text = "Мой наряд – мои доспехи, А мой отдых – жаркий бой.";
        }
        if (barprog.Value >= 60)
        {
            _unlock5.text = "Белый";
            _unlock6.text = "Шоколад";
        }
        if (barprog.Value >= 80)
        {
            _unlock7.text = "190 см";
            _unlock8.text = "80 кг";
        }
    }
}
