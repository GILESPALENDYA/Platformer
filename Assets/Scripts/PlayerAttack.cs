using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerAttack : MonoBehaviour
{
    public Animator anim;
    public Button button;


    private void Start()
    {
        button.onClick.AddListener(PlayerAnimation);
    }

    private void PlayerAnimation()
    {
        anim.SetTrigger("attack");
    }
}
