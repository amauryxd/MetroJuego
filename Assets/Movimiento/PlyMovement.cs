using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyMovement : MonoBehaviour
{
    
    private Rigidbody rb;
    public float PLYspeed;
    public Vector2 sensibility;
    public GameObject camara;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");
        float mousehor = Input.GetAxis("Mouse X");
        float mousever = Input.GetAxis("Mouse Y");

        if (hor != 0 || ver != 0)
        {
            Vector3 directionf = (transform.forward * ver).normalized; 
            Vector3 directionh = (transform.right * hor).normalized;
            rb.velocity = (directionf+directionh) * PLYspeed;
            Debug.Log(rb.velocity);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }

        if(mousehor != 0)
        {
            transform.Rotate(Vector3.up * mousehor * sensibility.x);
        }
        if(mousever != 0)
        {
            //camara.transform.Rotate(Vector3.left * ver * sensibility.y);
            float angle = (camara.transform.localEulerAngles.x - mousever * sensibility.y+360)%360;
            if(angle > 180) { angle -= 360; }
            angle = Mathf.Clamp(angle, -80, 80);
            camara.transform.localEulerAngles = Vector3.right * angle;
        }
    }
}
