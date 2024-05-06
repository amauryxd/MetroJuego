using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour , IInteractable
{
    public void Interact()
    {
        Inventory.inventario.Add(gameObject);
        gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform);
        gameObject.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
        gameObject.SetActive(false);
    }
}
