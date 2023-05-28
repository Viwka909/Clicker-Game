using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TableUnlocker2 : MonoBehaviour
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
            _unlock1.text = "Белый и Розовый";
            _unlock2.text = "Круассан и Наполеон";
        }
        if (barprog.Value >= 40)
        {
            _unlock3.text = "Игра на скрипке";
            _unlock4.text = "C'est la vie. — Такова жизнь.";
        }
        if (barprog.Value >= 60)
        {
            _unlock5.text = "коричневый";
            _unlock6.text = "паста";
        }
        if (barprog.Value >= 80)
        {
            _unlock7.text = "150 см";
            _unlock8.text = "45 кг";
        }
    }
}
