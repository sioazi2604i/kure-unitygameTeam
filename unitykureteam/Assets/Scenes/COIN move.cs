using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //TextMeshProを扱い際に必要になる

public class COINmove : MonoBehaviour
{
    public AudioClip GetCoinSound; //ゲームクリア音
    private AudioSource audioSource; //オーディオソース
    private GameObject Scoretext;

    void Start()
    {
        Scoretext = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 0.5f)); //transform.Rotate を使用
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "mario")
        {
        Scoretext.GetComponent<Score>().score = Scoretext.GetComponent<Score>().score + 1;
        Destroy(this.gameObject);    //当たったらコインを消す
        }
    }
}


//参考
//ゲーム開発で役立つ！Unityでオブジェクトを回転させる方法【初心者向け】
//https://magazine.techacademy.jp/magazine/9299
//https://yomeyome.hateblo.jp/entry/score_function