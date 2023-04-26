using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer1 : MonoBehaviour
{
    [SerializeField] private string _selectscreen = "SelectScreen";
    public void OnClick()
    {

        SceneManager.LoadScene(_selectscreen);
        Debug.Log("3156");
    }
}
