using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistolita : MonoBehaviour
{   
    RaycastHit hit;
    public bool hasRanged = false;
    

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward, Color.yellow);
        if (hasRanged == true)
        {
            if(Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(transform.position, transform.forward, out hit))
                {
                    if (hit.collider.gameObject.tag == "Enemy")
                    {
                        hit.collider.gameObject.GetComponent<EnemyHealth>().vidaMaloso--;

                    }
                }   
            }
        }
    }
}
