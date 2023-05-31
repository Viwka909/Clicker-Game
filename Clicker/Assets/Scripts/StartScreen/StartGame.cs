using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] private string _selectscreen = "SelectScreen";
    public AudioData _MasterVol;
    public AudioData _MusicVol;
    public AudioData _SFXVol;
    public GirlData barvalue1;
    public GirlData hrtval1;
    public GirlData barvalue2;
    public GirlData hrtval2;
    public GirlData barvalue3;
    public GirlData hrtval3;
    public GirlData barvalue4;
    public GirlData hrtval4;
    public void OnClick()
    {
        _MasterVol.Value = PlayerPrefs.GetFloat(_MasterVol.ToString(), 1);
        _MusicVol.Value = PlayerPrefs.GetFloat(_MusicVol.ToString(), 1);
        _SFXVol.Value = PlayerPrefs.GetFloat(_SFXVol.ToString(), 1);
        barvalue1.Value = PlayerPrefs.GetInt(barvalue1.ToString(), 0);
        barvalue2.Value = PlayerPrefs.GetInt(barvalue2.ToString(), 0);
        barvalue3.Value = PlayerPrefs.GetInt(barvalue3.ToString(), 0);
        barvalue4.Value = PlayerPrefs.GetInt(barvalue4.ToString(), 0);
        hrtval1.Value = PlayerPrefs.GetInt(hrtval1.ToString(), 0);
        hrtval2.Value = PlayerPrefs.GetInt(hrtval2.ToString(), 0);
        hrtval3.Value = PlayerPrefs.GetInt(hrtval3.ToString(), 0);
        hrtval4.Value = PlayerPrefs.GetInt(hrtval4.ToString(), 0);
        SceneManager.LoadScene(_selectscreen);
    }
}
