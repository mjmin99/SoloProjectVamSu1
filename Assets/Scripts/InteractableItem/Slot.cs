using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Items items;
    public int itemCount;
    public Image itemImage;

    public void Additem(Items _items)
    {
        items = _items;
        itemImage.sprite = items.itemImage;
        itemImage.enabled = true; // �̹����� ��Ȱ��ȭ�� �ִٸ� �ٽ� ���̰�
        SetColor(1); // ���̵��� ���� ����
    }

    private void SetColor(float _alpha)
    { 
        Color color = itemImage.color;
        color.a = _alpha;
        itemImage.color = color;
    }

    private void ClearSlot()
    {
        items = null;
        itemImage.sprite = null;
        itemCount = 0;
        SetColor(0);

    }
}
