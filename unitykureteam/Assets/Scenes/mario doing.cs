using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody rb;
    float speed = 3.0f;
    private bool isGround;  //boolä÷êî...ê^(true)Ç©ãU(false)Ç©Çîªï 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGround = false;   //(èâÇﬂÇÕî€íËÇµÇƒÇ®Ç≠)
    }

    // Update is called once per frame

    void Update()
    {

        if (Input.GetKey(KeyCode.Space) && isGround)
        {
            rb.velocity = transform.up * speed * 3;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && isGround)
        {
                rb.velocity = transform.right * speed * 2 + transform.up * speed * 3;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && isGround)
        {
            rb.velocity = -transform.right * speed * 2 + transform.up * speed * 3;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * speed * 2;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = -transform.right * speed * 2;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "yuka")
        {
            isGround = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "yuka")
        {
            isGround = false;
        }
    }
}