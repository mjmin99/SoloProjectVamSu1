using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class Slot : MonoBehaviour , IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{
    private Vector3 originPos;

    public Items items;
    public int itemCount;
    public Image itemImage;


    void Start()
    { 
        originPos = transform.position;
    }
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

    public void PointerEnter(int slotNum) //�׽�Ʈ��
    {
        Debug.Log(slotNum + "���� ����");
    }

    public void PointerExit(int slotNum) //�׽�Ʈ��
    {
        Debug.Log(slotNum + "���� ����");
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (items != null)
            {
                if (items.itemType == Items.ItemType.Equipment)
                {
                    Debug.Log(items.itemName + "�� �����߽��ϴ�.");
                }
                else
                {
                    Debug.Log(items.itemName + "�� ����߽��ϴ�.");
                    ClearSlot();
                }
            }
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (items != null)
        {
            DragSlot.instance.dragSlot = this;
            DragSlot.instance.DranSetImage(itemImage);
            DragSlot.instance.transform.position = eventData.position;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (items != null)
        {
            DragSlot.instance.transform.position = eventData.position;
        }
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        DragSlot.instance.SetColor(0);
        DragSlot.instance.dragSlot = null;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (DragSlot.instance.dragSlot != null)
        ChangeSlot();
    }

    private void ChangeSlot()
    {
        Items _tempItem = items;

        Additem(DragSlot.instance.dragSlot.items);

        if (_tempItem != null)
        {
            DragSlot.instance.dragSlot.Additem(_tempItem);
        }
        else
        { 
            DragSlot.instance.dragSlot.ClearSlot();
        }
    }
}
