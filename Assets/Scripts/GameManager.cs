using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [Header("# Game Control")]
    public float gametime;
    public float maxGameTime = 2 * 10f;

    [Header("# Player Info")]
    public int health;
    public int maxHealth;
    public int level;
    public int kill;
    public int exp;
    public int[] nextExp = { 3, 5, 10, 30, 60, 100, 150, 210, 280, 360, 450, 600 };

    [Header("# Game Object")]
    public PoolManager pool;
    public Player player;

    private void Awake()
    {
        instance = this; // 정적변수는 인스펙터창에서 변수 드래그앤드롭이 불가해서 여기서 이렇게 선언해야함
    }

    private void Start()
    {
        health = maxHealth;
    }
    private void Update()
    {
        gametime += Time.deltaTime;

        if (gametime > maxGameTime)
        {
            gametime = maxGameTime;
        }
    }

    public void GetExp()
    {
        exp++;

        if (exp == nextExp[level])
        {
            level++;
            exp = 0;
        }
    }
}
