using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Travelqp : MonoBehaviour
{

    public AudioClip SonidosRandom;
    private AudioSource source;
    public GameObject PanelMap;
    private bool Hidden;
    private bool OpenVisible;
    private bool Interact;
    public bool canopenmap;

    public void Start()
    {
        source = GetComponent<AudioSource>();
        PanelMap.SetActive(Hidden);
        OpenVisible = false;
        Interact = false;
        canopenmap = false;
    }
    private void Update()
    {
        if (Interact)
        {
            if (Input.GetKeyDown(KeyCode.M) && OpenVisible == false)
            {   
                PanelMap.SetActive(!Hidden);
                Cursor.lockState = CursorLockMode.None;
                GetComponent<PlyMovement>().enabled = false;
                OpenVisible = true;
                source.clip = SonidosRandom;
                source.Play();

            }
            else if (Input.GetKeyDown(KeyCode.M) && OpenVisible == true)
            {
                Cursor.lockState = CursorLockMode.Locked;
                GetComponent<PlyMovement>().enabled = true;
                PanelMap.SetActive(Hidden);
                OpenVisible = false;
                source.clip = SonidosRandom;
                source.Play();
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
