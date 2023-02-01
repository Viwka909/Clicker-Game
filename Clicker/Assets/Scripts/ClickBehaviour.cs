using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBehaviour : MonoBehaviour
{
    [SerializeField]  private int _multiply = 1;
    [SerializeField] private int _hearts = 0;
    [SerializeField] private int _incr = 25;
    [SerializeField] private int _cost1 = 100;
    [SerializeField] private int _cost2 = 10000;
    void Start()
    {
        InvokeRepeating("SlowUpdate", 0.0f, 0.5f);
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.U) && _hearts >= _cost1 * 10)
        {
            _multiply += 10;
            _hearts -= _cost1 * 10;
            _cost1 += 250;
            Debug.Log("Multiplier increased");
            Debug.Log("Current Multiplier :" + _multiply);
        }
        else if(Input.GetKeyUp(KeyCode.U) && _hearts >= _cost1)
        {
            _multiply++;
            _hearts -= _cost1;
            _cost1 += 25;
            Debug.Log("Multiplier increased");
            Debug.Log("Current Multiplier :"+ _multiply);
        }
        if(Input.GetKeyUp(KeyCode.Y) && _hearts >= _cost2)
        {
            _multiply+=25;
            _hearts -= _cost2;
            _cost2 += 1000;
            Debug.Log("Multiplier greatly increased");
            Debug.Log("Current Multiplier :" +_multiply);
        }
        if(Input.GetKeyUp(KeyCode.T) && _hearts >= _cost2 * 10)
        {
            _incr += 250;
            _hearts -= _cost2 * 10;
            _cost2 += 10000;
            Debug.Log("Passive income increased");
            Debug.Log("Current increment :" + _incr);
        }
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            _hearts += _incr * _multiply;
             Debug.Log(_hearts);
        }
    }
     void SlowUpdate()
    {
        _hearts += _incr;
    }
}
