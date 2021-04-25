using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Exploration/Inventory/items/Fuel")]
public class FuelObject : ItemObject
{
   
    private void Awake()
    {
        type = ItemType.Fuel;
    }
}
