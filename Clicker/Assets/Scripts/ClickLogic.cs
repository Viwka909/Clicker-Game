using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ClickLogic : MonoBehaviour
{
    [SerializeField] private int _hearts;
    public void OnClick()
    {
        _hearts++;
        Debug.Log("123");
    }
}
