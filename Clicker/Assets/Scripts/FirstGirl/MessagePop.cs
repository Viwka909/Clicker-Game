using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MessagePop : MonoBehaviour
{
    bool _check = true;
     [SerializeField]
    public GameObject SpeechBubble;
    public string first = "";
    public string second = "";
    public string third = "";
    public string fourth = "";
    string[] _messages = new string[4] { "", "", "","" };
    public TextMeshProUGUI MessageText;
    private void Start() {
        _messages[0] = first;
        _messages[1] = second;
        _messages[2] = third;
        _messages[3] = fourth;
    }
    public void Message()
    {
        if (_check == true)
        {
            SpeechBubble.SetActive(true);
            MessageText.text = _messages[Random.Range(0, 3)];
            _check = false;
            Invoke("DisableMesage", 7.0f);
        }
    }
    public void DisableMesage()
    {
        SpeechBubble.SetActive(false);
        Invoke("ActivateCheck", 1.0f);
    }
    public void ActivateCheck()
    {
        _check = true;
    }


}
