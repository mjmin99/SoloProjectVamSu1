using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ItemPickUp : MonoBehaviour
{
    public Items items;

    public void PickUp()
    {
        Debug.Log($"{items.itemName}��(��) ȹ���߽��ϴ�.");
        // �κ��丮�� �߰��ϴ� ������ ���⿡ �ۼ�
        Destroy(gameObject);
    }
}
