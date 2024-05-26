using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TPdeestaciones : MonoBehaviour
{
  
    public void Load(string escena)
    {
        SceneManager.LoadScene(escena);
    }
}
