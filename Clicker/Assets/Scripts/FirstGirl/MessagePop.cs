using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MessagePop : MonoBehaviour
{
    bool _check = true;
    string[] _messages = new string[3] { "Sample Text 1", "Sample Text 2", "Sample Text 3" };
    [SerializeField] public GameObject SpeechBubble;
    public TextMeshProUGUI MessageText;
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
