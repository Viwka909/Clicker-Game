using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    private void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;

    }
}
