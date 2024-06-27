using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlatform : MonoBehaviour
{
    [SerializeField] private GameObject mimi;
    [SerializeField] private float area;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            Instantiate(mimi, new Vector3(Random.Range(-area, area), transform.position.y, Random.Range(-area, area)), Quaternion.identity);
        }
    }
}
