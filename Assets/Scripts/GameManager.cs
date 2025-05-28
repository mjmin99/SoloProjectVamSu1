using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [Header("# Game Control")]
    public bool isLive;
    public float gametime;
    public float maxGameTime = 2 * 10f;

    [Header("# Player Info")]
    public int health;
    public int maxHealth;
    public int level;
    public int kill;
    public int exp;
    public int[] nextExp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

    [Header("# Game Object")]
    public PoolManager pool;
    public Player player;
    public LevelUp uiLevelUp;

    private void Awake()
    {
        instance = this; // 정적변수는 인스펙터창에서 변수 드래그앤드롭이 불가해서 여기서 이렇게 선언해야함
    }

    private void Start()
    {
        health = maxHealth;

        //임시로 작성
        uiLevelUp.Select(0);
    }
    private void Update()
    {
        if (!isLive)
            return;
        
        gametime += Time.deltaTime;

        if (gametime > maxGameTime)
        {
            gametime = maxGameTime;
        }
    }

    public void GetExp()
    {
        exp++;

        if (exp == nextExp[Mathf.Min(level, nextExp.Length-1)])
        {
            level++;
            exp = 0;
            uiLevelUp.show();
        }
    }

    public void Stop()
    {
        isLive = false;
        Time.timeScale = 0;
    }

    public void Resume()
    { 
        isLive = true;
        Time.timeScale = 1;
    }
}
