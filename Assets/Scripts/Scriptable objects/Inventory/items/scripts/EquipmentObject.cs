using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Exploration/Inventory/items/Equipment")]

public class EquipmentObject : ItemObject
{
    

    private void Awake()
    {
        type = ItemType.Equipment;
    }




}
