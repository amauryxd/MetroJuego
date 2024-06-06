using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVelocity : MonoBehaviour
{
    public PlyMovement movement;
    public int playerSpeed, playerGrav;

    private void OnTriggerEnter(Collider other)
    {
        movement.PLYspeed = playerSpeed;
        movement.gravedad = playerGrav;
    }
}
