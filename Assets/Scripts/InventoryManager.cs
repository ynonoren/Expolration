using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    public InventoryObject inventory;
    public bool resetInventoryOnStart;


    private void Start()
    {
        if (resetInventoryOnStart)
            ResetInventory();

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



}
