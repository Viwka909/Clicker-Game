using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeFix : MonoBehaviour
{
    public AudioData _MasterVol;
    public AudioData _MusicVol;
    public AudioData _SFXVol;
    public StartChecker Check;
    public void OnClick()
    {
        if (Check.Value == 0)
        {
            Check.Value++;
            _MasterVol.Value = PlayerPrefs.GetFloat(_MasterVol.ToString(), 1);
            _MusicVol.Value = PlayerPrefs.GetFloat(_MusicVol.ToString(), 1);
            _SFXVol.Value = PlayerPrefs.GetFloat(_SFXVol.ToString(), 1);
        }
    }


}
