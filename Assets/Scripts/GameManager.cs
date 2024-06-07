using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<EnemyHealth> enemyAIList;
    public string scenetoLoad;
    public GameObject FlashLight, Lights;
    // Start is called before the first frame update
    private void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "FirstLevel")
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach(EnemyHealth enemy in enemyAIList)
        {
            if(enemy.isDead == true)
            {
                enemyAIList.Remove(enemy);
            }
        }

        if (enemyAIList.Count == 0)
        {
            SceneManager.LoadScene(scenetoLoad);
        }

        if (enemyAIList.Count == 2)
        {
            FlashLight.SetActive(true);
            Lights.SetActive(false);
        }
    }
}
