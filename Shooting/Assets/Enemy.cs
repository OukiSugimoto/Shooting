using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Enemyの体力変数
    private int enemyHp;
    //ダメージの関数
    public void Damage()
    {
        //Enemyの体力1減らす
        enemyHp = enemyHp - 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        //生成時の体力指定
        enemyHp = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //体力が3以下になったら
        if (enemyHp <= 0)
        {
            //自分で消える
            Destroy(this.gameObject);
        }
    }
}
