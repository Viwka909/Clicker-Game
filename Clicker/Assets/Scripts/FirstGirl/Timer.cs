using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;
    public TextMeshProUGUI Timertext;
    public GameObject _Timer;
    public GameObject Girl;
    public Sprite NormalState;
    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                UpdateTimer(TimeLeft);
            }
            else
            {
                TimeLeft = 0;
                Invoke("DisableTimer",0.1f);
                TimerOn = false;
            }
        }
    }
    void UpdateTimer(float currentTime)
    {
        currentTime += 1;
        float seconds = Mathf.FloorToInt(currentTime % 60);
        Timertext.text = string.Format("{0}",seconds);
    }
    void DisableTimer(){
        Timertext.text = string.Format(" ");
        Girl.GetComponent<Image>().sprite = NormalState;
        ClickLogic counter = FindObjectOfType<ClickLogic>();
        counter.modifier = 1;
    }
}
