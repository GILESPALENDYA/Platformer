using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Btn_Menu : MonoBehaviour
{
    public Button btnMenu;

    private void Start()
    {
        btnMenu.onClick.AddListener(GoToMenuAgain);
    }

    private void GoToMenuAgain()
    {
        SceneManager.LoadScene("SceneMenu");
    }
}
