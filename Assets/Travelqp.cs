using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Travelqp : MonoBehaviour
{
    public GameObject canvas;
    private bool Hidden;
    private bool OpenVisible;
    private bool Interact;

    public void Start()
    {
        canvas.SetActive(Hidden);
        OpenVisible = false;
        Interact = false;
    }
    private void Update()
    {
        if (Interact)
        {
            if (Input.GetKeyDown(KeyCode.M) && OpenVisible == false)
            {
                canvas.SetActive(!Hidden);
                Cursor.lockState = CursorLockMode.None;
                GetComponent<PlyMovement>().enabled = false;
                OpenVisible = true;
            }
            else if (Input.GetKeyDown(KeyCode.M) && OpenVisible == true)
            {
                Cursor.lockState = CursorLockMode.Locked;
                GetComponent<PlyMovement>().enabled = true;
                canvas.SetActive(Hidden);
                OpenVisible = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Interact = true;   
    }
    private void OnTriggerExit(Collider other)
    {
        Interact = false;
    }
}
