using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Items items;
    public Inventory theInventory;


    private void Start()
    {
        if (theInventory == null)
            theInventory = FindObjectOfType<Inventory>();
    }
    public void PickUp()
    {
        if (items == null)
        {
            Debug.LogError("ItemPickUp: items is null!");
            return;
        }

        if (theInventory == null)
        {
            Debug.LogError("ItemPickUp: theInventory is null!");
            return;
        }

        theInventory.AcquireItem(items);
        Destroy(gameObject);
    }
}
