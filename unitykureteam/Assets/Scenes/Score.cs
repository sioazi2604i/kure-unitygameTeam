using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text Scoretext;
    public int score = 0;

    void Start()
    {
        Scoretext = GetComponentInChildren<Text>();
        Scoretext.text = "0";
    }
    void Update()
    {
        Scoretext.text = score.ToString();
    }
}
