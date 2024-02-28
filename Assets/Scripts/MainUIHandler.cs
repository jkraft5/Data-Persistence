using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainUIHandler : MonoBehaviour
{
    public TMP_InputField username;
    public TMP_Text highScoreText;

    private void Start()
    {
        MainManager.Instance.LoadScore();
        if (MainManager.Instance.highScore > 0)
        {
            highScoreText.text = "High Score: " + MainManager.Instance.name + " : " + MainManager.Instance.highScore;
        }
    }

    public void StartNew()
    {
        MainManager.Instance.currentPlayer = username.text;
        Debug.Log(username.text);
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
