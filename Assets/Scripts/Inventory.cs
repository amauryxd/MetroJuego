using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{

    [SerializeField] public static List<GameObject> inventario = new List<GameObject>();
    [SerializeField] public List<GameObject> casillas = new List<GameObject>();
    public GameObject cube;
    GameObject prehecho;
    bool instanciado=false;
    public static bool canMoveCamera=true;
    bool abierto = false;
    public GameObject containerxd;
    int wich;
    bool isHovering;
    public Sprite defImg;
    public TextMeshProUGUI nombre;
    public TextMeshProUGUI desc;
    public bool isEquiped;
    public GameObject arma1;
    public GameObject arma2;

    // Start is called before the first frame update
    void Start()
    {
        instanciado = false;
        canMoveCamera = true;
        abierto = false;
        isHovering = false;
        isEquiped = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.I) && abierto==false)
        {
            Cursor.lockState = CursorLockMode.None;
            canMoveCamera = false;
            containerxd.SetActive(true);
            abierto = true;
            //inventario[0].transform.SetParent(null);
            //inventario[0].transform.position = GameObject.FindGameObjectWithTag("DropPoint").transform.position;     
            //inventario[0].SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.I) && abierto ==true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            canMoveCamera = true;
            containerxd.SetActive(false);
            abierto = false;
            limpieza();
        }

        if (Input.GetKeyDown(KeyCode.Q) && abierto && isHovering && inventario.Count > 0)
        {
            inventario[wich].transform.SetParent(null);
            inventario[wich].transform.position = GameObject.FindGameObjectWithTag("DropPoint").transform.position;
            inventario[wich].SetActive(true);
            inventario.RemoveAt(wich);
            AnotherRefresh();
            limpieza();
            if (arma1.activeInHierarchy)
            {
                Pistolita.hasRanged = false;
                isEquiped = false;
                arma1.SetActive(false);
            }
            if (arma2.activeInHierarchy)
            {
                MeleeCombat1.Melee = false;
                isEquiped = false;
                arma2.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.E) && abierto && isHovering && inventario.Count > 0 && isEquiped==false)
        {
            if (inventario[wich].GetComponent<ItemGet>().info.IsGun)
            {
                Pistolita.hasRanged = true;
                isEquiped = true;
                arma1.SetActive(true);
            }
            if (inventario[wich].GetComponent<ItemGet>().info.IsMelee)
            {
                MeleeCombat1.Melee = true;
                isEquiped = true;
                arma2.SetActive(true);
            }
        }else if(Input.GetKeyDown(KeyCode.E) && abierto && isHovering && inventario.Count > 0 && isEquiped)
        {
            if (inventario[wich].GetComponent<ItemGet>().info.IsGun && !arma2.activeInHierarchy)
            {
                Pistolita.hasRanged = false;
                isEquiped = false;
                arma1.SetActive(false);
            }
            if (inventario[wich].GetComponent<ItemGet>().info.IsMelee && !arma1.activeInHierarchy)
            {
                MeleeCombat1.Melee = false;
                isEquiped = false;
                arma2.SetActive(false);
            }
        }
        else { }
    }

    public void limpieza()
    {
        Destroy(prehecho);
        instanciado = false;
        isHovering = false;
        nombre.text = "Nombre";
        desc.text = "Descripcion";
    }

    public void RefreshInventory()
    {
        casillas[Inventory.inventario.Count - 1].GetComponent<Image>().sprite = Inventory.inventario[Inventory.inventario.Count - 1].GetComponent<ItemGet>().info.Img;
    }

    public void AnotherRefresh()
    {
        for(int i=0; i<= casillas.Count-1; i++)
        {
            casillas[i].GetComponent<Image>().sprite = defImg;
        }
        for(int i=0; i <= inventario.Count-1; i++)
        {
            casillas[i].GetComponent<Image>().sprite = inventario[i].GetComponent<ItemGet>().info.Img;
        }
    }

    public void MostrarObjetoC0()
    {
        wich = 0;
        isHovering = true;
        if (Inventory.inventario.Count > 0)
        {
            if (!instanciado)
            {
                prehecho = Instantiate(Inventory.inventario[wich].GetComponent<ItemGet>().info.Modelo, cube.transform.position, cube.transform.rotation, cube.transform);
                instanciado = true;
            }
            nombre.text = inventario[wich].GetComponent<ItemGet>().info.ItemName;
            desc.text = inventario[wich].GetComponent<ItemGet>().info.Descrip;

        }
    }
    public void MostrarObjetoC1()
    {
        wich = 1;
        isHovering = true;
        if (Inventory.inventario.Count > 1)
        {
            if (!instanciado)
            {
                prehecho = Instantiate(Inventory.inventario[wich].GetComponent<ItemGet>().info.Modelo, cube.transform.position, cube.transform.rotation, cube.transform);
                instanciado = true;
            }
        }
    }
    public void MostrarObjetoC2()
    {
        wich = 2;
        isHovering = true;
        if (Inventory.inventario.Count > 2)
        {
            if (!instanciado)
            {
                prehecho = Instantiate(Inventory.inventario[wich].GetComponent<ItemGet>().info.Modelo, cube.transform.position, cube.transform.rotation, cube.transform);
                instanciado = true;
            }
        }
    }
    public void MostrarObjetoC3()
    {
        wich = 3;
        isHovering = true;
        if (Inventory.inventario.Count > 3)
        {
            if (!instanciado)
            {
                prehecho = Instantiate(Inventory.inventario[wich].GetComponent<ItemGet>().info.Modelo, cube.transform.position, cube.transform.rotation, cube.transform);
                instanciado = true;
            }
        }
    }
    public void MostrarObjetoC4()
    {
        wich = 4;
        isHovering = true;
        if (Inventory.inventario.Count > 4)
        {
            if (!instanciado)
            {
                prehecho = Instantiate(Inventory.inventario[wich].GetComponent<ItemGet>().info.Modelo, cube.transform.position, cube.transform.rotation, cube.transform);
                instanciado = true;
            }
        }
    }
    public void MostrarObjetoC5()
    {
        wich = 5;
        isHovering = true;
        if (Inventory.inventario.Count > 5)
        {
            if (!instanciado)
            {
                prehecho = Instantiate(Inventory.inventario[wich].GetComponent<ItemGet>().info.Modelo, cube.transform.position, cube.transform.rotation, cube.transform);
                instanciado = true;
            }
        }
    }
    public void MostrarObjetoC6()
    {
        wich = 6;
        isHovering = true;
        if (Inventory.inventario.Count > 6)
        {
            if (!instanciado)
            {
                prehecho = Instantiate(Inventory.inventario[wich].GetComponent<ItemGet>().info.Modelo, cube.transform.position, cube.transform.rotation, cube.transform);
                instanciado = true;
            }
        }
    }
    public void MostrarObjetoC7()
    {
        wich = 7;
        isHovering = true;
        if (Inventory.inventario.Count > 7)
        {
            if (!instanciado)
            {
                prehecho = Instantiate(Inventory.inventario[wich].GetComponent<ItemGet>().info.Modelo, cube.transform.position, cube.transform.rotation, cube.transform);
                instanciado = true;
            }
        }
    }
    public void MostrarObjetoC8()
    {
        wich = 8;
        isHovering = true;
        if (Inventory.inventario.Count > 8)
        {
            if (!instanciado)
            {
                prehecho = Instantiate(Inventory.inventario[wich].GetComponent<ItemGet>().info.Modelo, cube.transform.position, cube.transform.rotation, cube.transform);
                instanciado = true;
            }
        }
    }
    public void MostrarObjetoC9()
    {
        wich = 9;
        isHovering = true;
        if (Inventory.inventario.Count > 9)
        {
            if (!instanciado)
            {
                prehecho = Instantiate(Inventory.inventario[wich].GetComponent<ItemGet>().info.Modelo, cube.transform.position, cube.transform.rotation, cube.transform);
                instanciado = true;
            }
        }
    }
    public void MostrarObjetoCA()
    {
        wich = 10;
        isHovering = true;
        if (Inventory.inventario.Count > 10)
        {
            if (!instanciado)
            {
                prehecho = Instantiate(Inventory.inventario[wich].GetComponent<ItemGet>().info.Modelo, cube.transform.position, cube.transform.rotation, cube.transform);
                instanciado = true;
            }
        }
    }
    public void MostrarObjetoCB()
    {
        wich = 11;
        isHovering = true;
        if (Inventory.inventario.Count > 11)
        {
            if (!instanciado)
            {
                prehecho = Instantiate(Inventory.inventario[wich].GetComponent<ItemGet>().info.Modelo, cube.transform.position, cube.transform.rotation, cube.transform);
                instanciado = true;
            }
        }
    }
}
