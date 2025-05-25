using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    // ��������� ������ ���� ���� 
    public GameObject[] prefabs;


    // Ǯ ����� �ϴ� ����Ʈ�� �ϳ� �ʿ�
    List<GameObject>[] pools;

    private void Awake()
    {
        pools = new List<GameObject>[prefabs.Length];

        for (int index = 0; index < pools.Length; index++)
        {
            pools[index] = new List<GameObject>();
        }

        // Debug.Log(Pools.Length); ������ Ǯ�� ���� ����׿�
    }

    public GameObject Get(int index)
    {
        GameObject select = null;

        // ������ Ǯ�� ��� �ִ�(��Ȱ��ȭ��) ���ӿ�����Ʈ ����
        foreach (GameObject item in pools[index])
        {
            if (!item.activeSelf)
            {
                // �߰��ϸ� ����Ʈ ������ �Ҵ�
                select = item;
                select.SetActive(true);
                break;

            }
        }

        //��ã����?
        if (!select)
        { //���� �����ؼ� ����Ʈ ������ �Ҵ�

            select = Instantiate(prefabs[index], transform);
            pools[index].Add(select);
        }


            
        return select;
    }
}
