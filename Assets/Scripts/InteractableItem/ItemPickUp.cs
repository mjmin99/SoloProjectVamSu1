using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ItemPickUp : MonoBehaviour
{
    public Items items;

    public void PickUp()
    {
        Debug.Log($"{items.itemName}을(를) 획득했습니다.");
        // 인벤토리에 추가하는 로직을 여기에 작성
        Destroy(gameObject);
    }
}
