using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Exploration/Inventory/items/Default")]
public class DefaultObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.Default;
    }
}
