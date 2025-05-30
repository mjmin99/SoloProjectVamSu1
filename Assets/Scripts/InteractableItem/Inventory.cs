using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static bool inventoryActivated = false;

    [SerializeField]
    private GameObject go_InventoryBase;
    [SerializeField]
    private GameObject go_SlotParent;

    private Slot[] slots;

    private void Awake()
    {
        slots = go_SlotParent.GetComponentsInChildren <Slot>();
    }

    private void Update()
    {
        TryOpenInventory();
    }

    private void TryOpenInventory()
    { 
        if(Input.GetKeyDown(KeyCode.I))
        { 
            inventoryActivated = !inventoryActivated;

            if (inventoryActivated)
            {
               OpenInventory();
            }
            else
            {
                CloseInventory();
            }
        }
    }

    private void OpenInventory()
    { 
        go_InventoryBase.SetActive(true);
    }

    private void CloseInventory()
    { 
        go_InventoryBase?.SetActive(false);
    }

    public void AcquireItem(Items _items)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            // 슬롯이 비어 있으면 아이템 추가
            if (slots[i].items == null)
            {
                slots[i].Additem(_items);
                slots[i].itemCount = 1;
                return;
            }
        }
    }

}
