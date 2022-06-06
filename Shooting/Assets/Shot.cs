using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    //ゲームオブジェクトをインスペクターから参照
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //弾を生成
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
    }
}
