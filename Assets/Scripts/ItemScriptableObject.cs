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
    [SerializeField] private bool isGun;
    [SerializeField] private bool isMelee;

    public string ItemName { get { return itemName; } }
    public Sprite Img { get { return img; } }
    public GameObject Modelo { get { return modelo; } }
    public string Descrip { get { return descrip; } }
    public bool IsGun { get { return isGun; } }
    public bool IsMelee { get { return isMelee; } }
}
