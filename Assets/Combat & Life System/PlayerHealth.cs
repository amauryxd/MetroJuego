using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public int vidaPlayer = 5;
    private void Awake()
    {
        textMeshProUGUI = GameObject.Find("PlayerLife").GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        textMeshProUGUI.text = vidaPlayer.ToString();
        
        if(vidaPlayer == 0)
        {
            SceneManager.LoadScene("Menu");
        }

    }

}
