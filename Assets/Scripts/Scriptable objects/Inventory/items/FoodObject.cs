using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Exploration/Inventory/items/Food")]

public class FoodObject : ItemObject
{
    
    private void Awake()
    {
        type = ItemType.Food;
    }
}
