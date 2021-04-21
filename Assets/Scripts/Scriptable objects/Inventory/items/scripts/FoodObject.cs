using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Exploration/Inventory/items/Food")]

public class FoodObject : ItemObject
{
    public int restoreHealthValue;
    private void Awake()
    {
        type = ItemType.Food;
    }
}
