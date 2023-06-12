using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Btn_Start : MonoBehaviour
{
    public Button btnStart;

    private void Start()
    {
        btnStart.onClick.AddListener(GoToMain);
    }

    private void GoToMain()
    {
        SceneManager.LoadScene("Scene1");
    }
}
