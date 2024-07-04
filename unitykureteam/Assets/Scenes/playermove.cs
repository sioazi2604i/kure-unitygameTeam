using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector3(0, 0, 1));

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-0.05f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, 0, 0.05f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, 0, -0.05f);
        }
    }
}