using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 총알의 갯수 - 데이터
    // 1개,2개,3개
    public int bulletCount = 10;
    public Rigidbody bullet;
    public Transform firePos;
    public TMP_Text TxtBulletCount;

    private void Start()
    {
        RefreshBulletCountUI();
    }


    // 총알을 발사 - 기능[함수]
    // 총을 쏜다
    public void Shoot()
    {
        if (bulletCount <= 0)
            return;

        // 오브젝트를 생성
        //Instantiate(bullet);

        // 오브젝트를 생성 - firePos 안쪽에 위치
        //Instantiate(bullet, firePos);

        // 오브젝트를 생성 - 벡터의 위치에 생성, Quaternion의 회전값
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