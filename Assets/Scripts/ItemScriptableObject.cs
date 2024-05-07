using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Item SOB", menuName ="Item SOB")]
public class ItemScriptableObject : ScriptableObject
{
    [SerializeField] private string itemName;
    [SerializeField] private Sprite img;
    [SerializeField] private GameObject modelo;
    [TextArea(10, 10)]
    [SerializeField] private string descrip;

    public string ItemName { get { return itemName; } }
    public Sprite Img { get { return img; } }
    public GameObject Modelo { get { return modelo; } }
    public string Descrip { get { return descrip; } }
}
