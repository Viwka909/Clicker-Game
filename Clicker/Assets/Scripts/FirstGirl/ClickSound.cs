using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ClickSound : MonoBehaviour
{
  public AudioSource clicksound;
  public void SoundOnClick(){
    clicksound.Play();
  }
}
