using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // �Ѿ��� ���� - ������
    // 1��,2��,3��
    public int bulletCount = 10;
    public Rigidbody bullet;
    public Transform firePos;
    public TMP_Text TxtBulletCount;

    private void Start()
    {
        RefreshBulletCountUI();
    }


    // �Ѿ��� �߻� - ���[�Լ�]
    // ���� ���
    public void Shoot()
    {
        if (bulletCount <= 0)
            return;

        // ������Ʈ�� ����
        //Instantiate(bullet);

        // ������Ʈ�� ���� - firePos ���ʿ� ��ġ
        //Instantiate(bullet, firePos);

        // ������Ʈ�� ���� - ������ ��ġ�� ����, Quaternion�� ȸ����
        Rigidbody bulletObj = Instantiate(bullet, firePos.position, firePos.rotation);
        bulletObj.AddForce(firePos.forward * 50, ForceMode.Impulse);

        bulletCount--; 

        RefreshBulletCountUI();
    }

    void RefreshBulletCountUI()
    {
        TxtBulletCount.text = bulletCount.ToString();
    }
}