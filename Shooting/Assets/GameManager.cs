using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //敵の数を数える用の変数
    private GameObject[] enemy;

    //パネルを登録
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        //パネルを隠す
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Enemyタグを持っているオブジェクト
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        //Enemyがいなくなったら
        if (enemy.Length == 0)
        {
            //パネル表示
            panel.SetActive(true);
        }
    }
}
