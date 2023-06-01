using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffTutor : MonoBehaviour
{
    public GameObject Tutor;
    public void OnClick(){
        Tutor.SetActive(false);
    }
}
