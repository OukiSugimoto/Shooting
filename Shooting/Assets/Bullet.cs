using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //弾のワールド座標
        Vector3 pos = transform.position;

        //上にまっすぐ
        pos.z += 0.05f;

        //弾の移動
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        //一定距離で消滅
        if (pos.z >= 20)
        {
            Destroy(this.gameObject);
        }
    }
    //当たり判定用関数
    private void OnTriggerEnter(Collider other)
    {
        //当たったオブジェクトがEnemyだったら
        if (other.gameObject.tag == "Enemy")
        {
            //ダメージ関数の実行
            other.GetComponent<Enemy>().Damage();
            //自分で消える
            Destroy(this.gameObject);
        }
    }
}
