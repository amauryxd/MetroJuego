using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    [SerializeField] public static List<GameObject> inventario = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            inventario[0].transform.SetParent(null);
            inventario[0].transform.position = GameObject.FindGameObjectWithTag("DropPoint").transform.position;     
            inventario[0].SetActive(true);
        }
    }
}
