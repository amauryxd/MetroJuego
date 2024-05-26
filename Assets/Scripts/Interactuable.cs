using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactuable : MonoBehaviour
{
    public static bool Dialogue2 = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interactuable"))
        {
            Debug.Log("uwu");
            Dialogue2 = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Dialogue2 = false;
    }

}
