using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // �Ѿ��� ���� - ������
    // 1��,2��,3��
    public int bulletCount = 10;
    public Rigidbody bullet;
    public Transform firePos;

    // �Ѿ��� �߻� - ���[�Լ�]
    // ���� ���
    public void Shoot()
    {
        // ������Ʈ�� ����
        //Instantiate(bullet);

        // ������Ʈ�� ���� - firePos ���ʿ� ��ġ
        //Instantiate(bullet, firePos);

        // ������Ʈ�� ���� - ������ ��ġ�� ����, Quaternion�� ȸ����
        Rigidbody bulletObj = Instantiate(bullet, firePos.position, firePos.rotation);
        bulletObj.AddForce(firePos.forward * 100, ForceMode.Impulse);
    }
}