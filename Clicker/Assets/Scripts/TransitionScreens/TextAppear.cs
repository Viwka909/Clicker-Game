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
}
