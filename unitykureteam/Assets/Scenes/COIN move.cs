using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //TextMeshPro�������ۂɕK�v�ɂȂ�

public class COINmove : MonoBehaviour
{
    public AudioClip GetCoinSound; //�Q�[���N���A��
    private AudioSource audioSource; //�I�[�f�B�I�\�[�X
    private GameObject Scoretext;

    void Start()
    {
        Scoretext = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 0.5f)); //transform.Rotate ���g�p
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "mario")
        {
        Scoretext.GetComponent<Score>().score = Scoretext.GetComponent<Score>().score + 1;
        Destroy(this.gameObject);    //����������R�C��������
        }
    }
}


//�Q�l
//�Q�[���J���Ŗ𗧂IUnity�ŃI�u�W�F�N�g����]��������@�y���S�Ҍ����z
//https://magazine.techacademy.jp/magazine/9299
//https://yomeyome.hateblo.jp/entry/score_function