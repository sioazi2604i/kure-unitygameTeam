using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    [SerializeField] private GameObject platform;
    [SerializeField] private float moveGain = 1f;
    [SerializeField] private float moveLength = 10f;
    private Rigidbody rig;
    private float moveY = 0f;
    private bool Is_Uping;

    // Start is called before the first frame update
    void Start()
    {
        rig = platform.GetComponent<Rigidbody>();
        Is_Uping = true;

    }

    // Update is called once per frame
    void Update()
    {
        moveY += Time.deltaTime * (Is_Uping ? moveGain : -moveGain);

        // if(moveY > 10f) Is_Uping = false;
        // if(moveY < 0f) Is_Uping = true;

        // rig.velocity = new Vector3(transform.position.x, (float)Math.Sin(moveY) * moveLength, transform.position.z);
        rig.velocity = new Vector3(0f, (float)Math.Sin(moveY) * moveLength, 0f);
    }
}
