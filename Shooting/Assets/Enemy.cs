using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Enemy�̗͕̑ϐ�
    private int enemyHp;
    //�_���[�W�̊֐�
    public void Damage()
    {
        //Enemy�̗̑�1���炷
        enemyHp = enemyHp - 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        //�������̗͎̑w��
        enemyHp = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //�̗͂�3�ȉ��ɂȂ�����
        if (enemyHp <= 0)
        {
            //�����ŏ�����
            Destroy(this.gameObject);
        }
    }
}
