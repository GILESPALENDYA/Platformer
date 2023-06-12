using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Btn_End : MonoBehaviour
{
    public Button btnEnd;

    private void Start()
    {
        btnEnd.onClick.AddListener(GoToEnd);
    }

    private void GoToEnd()
    {
        SceneManager.LoadScene("SceneEnd");
    }
}
