using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float gametime;
    public float maxGameTime = 2 * 10f;


    public PoolManager pool;
    public Player player;

    private void Awake()
    {
        instance = this; // ���������� �ν�����â���� ���� �巡�׾ص���� �Ұ��ؼ� ���⼭ �̷��� �����ؾ���
    }
    private void Update()
    {
        gametime += Time.deltaTime;

        if (gametime > maxGameTime)
        {
            gametime = maxGameTime;
        }
    }
}
