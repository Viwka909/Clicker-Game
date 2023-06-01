using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinaleTransfer : MonoBehaviour
{
    public Animator transition;
    [SerializeField] private string _selectscreen = "SelectScreen";
    public AudioSource audioSource;
    public GirlUnlockCheck End;

    public void OnClick()
    {
            StartCoroutine(StartFade(audioSource, 1, 0));
            End.Value++;
            StartCoroutine(LoadTransition());
    }

    IEnumerator LoadTransition()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
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
