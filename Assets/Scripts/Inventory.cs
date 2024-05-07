using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Inventory : MonoBehaviour
{

    [SerializeField] public static List<GameObject> inventario = new List<GameObject>();
    [SerializeField] public List<GameObject> casillas = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
        
        if (Input.GetKeyDown(KeyCode.I))
        {
            Cursor.lockState = CursorLockMode.None;
            //inventario[0].transform.SetParent(null);
            //inventario[0].transform.position = GameObject.FindGameObjectWithTag("DropPoint").transform.position;     
            //inventario[0].SetActive(true);
        }
    }

    public void MostrarObjeto()
    {
        Debug.Log("mouseneconma");
    }

    public void RefreshInventory()
    {
        casillas[Inventory.inventario.Count - 1].GetComponent<Image>().sprite = Inventory.inventario[Inventory.inventario.Count - 1].GetComponent<ItemGet>().info.Img;
    }
}
