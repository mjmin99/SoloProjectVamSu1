using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player;

    private void Awake()
    {
        instance = this; // 정적변수는 인스펙터창에서 변수 드래그앤드롭이 불가해서 여기서 이렇게 선언해야함
    }
}
