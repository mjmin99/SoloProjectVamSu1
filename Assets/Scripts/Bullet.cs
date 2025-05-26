using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;
    public int per;

    public void Init(float damage, int per)
    { 
        this.damage = damage; // this 붙이면 클래스의 변수 안붙이면 함수 내 변수
        this.per = per;
    }
}
