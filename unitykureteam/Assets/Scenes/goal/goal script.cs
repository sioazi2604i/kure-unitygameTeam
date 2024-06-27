using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goalscript : MonoBehaviour
{
    public GameObject chara;
    public GameObject gameclea;
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("ok");
        if(other.name==chara.name)
        {
            gameclea.GetComponent<Text>();
            gameclea.SetActive(true);
            chara.SetActive(false);
        }
    }
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
