using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    public InventoryObject inventory;
  

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            inventory.Save();
        }

        if (Input.GetKeyDown(KeyCode.F9))
        {
            inventory.Load();
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
            inventory.AddItem(new Item(item.item), 1);
            Destroy(other.gameObject);
        }
    }

    private void OnApplicationQuit()
    {
        inventory.Container.Items.Clear();
    }

}
