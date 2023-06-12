using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Btn_Home : MonoBehaviour
{
    public Button btnHome;

    private void Start()
    {
        btnHome.onClick.AddListener(BackToHome);
    }
    private void BackToHome()
    {
        SceneManager.LoadScene("SceneMenu");
    }
}
