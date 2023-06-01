using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextAppear : MonoBehaviour
{
    [SerializeField] private string _selectscreen = "SelectScreen";
    public Animator transition;
    public AudioSource audioSource;
    public float delay = 0.1f;
    public string fullText;
    public TextMeshProUGUI Text;
    public GameObject Next;
    private string currentText = "";
    int check = 0;

    public void OnClick()
    {
        if (check == 0)
        {
            check++;
            Next.SetActive(false);
            StartCoroutine(ShowText());
        }
        else
        {
            StartCoroutine(LoadLevel());
            StartCoroutine(StartFade(audioSource,2,0));
        }
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            Text.text = currentText;
            yield return new WaitForSeconds(delay);
        }
        Next.SetActive(true);
    }
    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(_selectscreen);
    }
     public static IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audioSource.volume;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }
}
