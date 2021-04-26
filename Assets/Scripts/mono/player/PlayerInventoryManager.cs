using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryManager : MonoBehaviour
{
  
    public InventoryObject inventory;
   public InventoryObject equipment;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            inventory.Save();
            equipment.Save();
        }

        if (Input.GetKeyDown(KeyCode.F9))
        {
            inventory.Load();
            equipment.Load();
        }

    }
    public void AddToInventory()
    {
        
   
    }

  
    //replace with gamevent
    public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<GroundItem>();
        if (item)
        {
            Item _item = new Item(item.item);
            if (inventory.AddItem(_item, 1))
            {
                Destroy(other.gameObject);
            }  
        }
    }

    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
        equipment.Container.Clear();
    }

}
