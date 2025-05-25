using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    // 프리펩들을 보관할 변수 생성 
    public GameObject[] prefabs;


    // 풀 담당을 하는 리스트가 하나 필요
    List<GameObject>[] pools;

    private void Awake()
    {
        pools = new List<GameObject>[prefabs.Length];

        for (int index = 0; index < pools.Length; index++)
        {
            pools[index] = new List<GameObject>();
        }

        // Debug.Log(Pools.Length); 생성된 풀의 갯수 디버그용
    }

    public GameObject Get(int index)
    {
        GameObject select = null;

        // 선택한 풀에 놀고 있는(비활성화된) 게임오브젝트 접근
        foreach (GameObject item in pools[index])
        {
            if (!item.activeSelf)
            {
                // 발견하면 셀렉트 변수에 할당
                select = item;
                select.SetActive(true);
                break;

            }
        }

        //못찾으면?
        if (!select)
        { //새로 생성해서 셀렉트 변수에 할당

            select = Instantiate(prefabs[index], transform);
            pools[index].Add(select);
        }


            
        return select;
    }
}
