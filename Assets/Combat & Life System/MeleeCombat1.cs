using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeCombat1 : MonoBehaviour
{
    public bool Melee = false;
    void OnTriggerStay(Collider other)
    {
        if (Melee == true)
        {
            if(Input.GetMouseButtonDown(0))
            {
                if (other.CompareTag("Enemy"))
                {
                    other.GetComponent<EnemyHealth>().vidaMaloso--;
                }
            }
        }
        
    }
}
