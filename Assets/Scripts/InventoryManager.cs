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

    public void ResetInventory()
    {
        inventory.Container.Clear();
    }
    //replace with gamevent
    public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<Item>();
        if (item)
        {
            inventory.AddItem(item.item, 1);
            Destroy(other.gameObject);
        }
    }

    private void OnApplicationQuit()
    {
        ResetInventory();
    }

}
