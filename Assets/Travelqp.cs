using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Travelqp : MonoBehaviour
{
    public GameObject canvas;
    private bool Hidden;

    public void Start()
    {
        canvas.SetActive(Hidden);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            canvas.SetActive(!Hidden);
            Cursor.lockState = CursorLockMode.None;
            GetComponent<PlyMovement>().enabled = false;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.Locked;
            GetComponent<PlyMovement>().enabled = true;
            canvas.SetActive(Hidden);
        }
    }
}
