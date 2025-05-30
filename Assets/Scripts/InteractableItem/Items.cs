using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = ("New Item/item"))]
public class Items : ScriptableObject
{
    public string itemName;
    public ItemType itemType;
    public Sprite itemImage;
    public GameObject itemPrefab;

    public string weaponType;

    public enum ItemType { Equipment, Used, Ingredient, ETC }

}
