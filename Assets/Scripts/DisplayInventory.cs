﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
    public GameObject inventoryPrefab;
    public InventoryObject inventory;
    public int X_START;
    public int Y_START;
    public int X_SPACE_BETWEEN_ITEM;
    public int NUMBER_OF_COLOMN;
    public int Y_SPACE_BETWEEN_ITEM;
    Dictionary<InventorySlot, GameObject> itemDisplayed=new Dictionary<InventorySlot, GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        CreateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDisplay();
    }
    public void UpdateDisplay()
    {
        for (int i = 0; i < inventory.Container.Items.Count; i++)
        {
            InventorySlot slot = inventory.Container.Items[i];
            if (itemDisplayed.ContainsKey(slot))
            {
                itemDisplayed[slot].GetComponentInChildren<Text>().text = slot.amount.ToString("n0");
            }
            else
            {
                var obj = Instantiate(inventoryPrefab, Vector3.zero, Quaternion.identity, transform);
                obj.transform.GetChild(0).GetComponentInChildren<Image>().sprite = inventory.database.GetItem[slot.item.Id].uiDisplay;
                obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                obj.GetComponentInChildren<Text>().text = slot.amount.ToString("n0");
                itemDisplayed.Add(slot, obj);
            }
        }
    }
    public void CreateDisplay() 
    {
       
        for (int i = 0; i < inventory.Container.Items.Count; i++)
        {
            InventorySlot slot = inventory.Container.Items[i];

            var obj = Instantiate(inventoryPrefab, Vector3.zero, Quaternion.identity, transform);
            obj.transform.GetChild(0).GetComponentInChildren<Image>().sprite = inventory.database.GetItem[slot.item.Id].uiDisplay;
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            obj.GetComponentInChildren<Text>().text = slot.amount.ToString("n0");
            itemDisplayed.Add(slot, obj);
        }
    }

  



    public Vector3 GetPosition(int i)
    {
        return new Vector3(X_START+(X_SPACE_BETWEEN_ITEM * (i % NUMBER_OF_COLOMN)), Y_START+(-Y_SPACE_BETWEEN_ITEM * (i / NUMBER_OF_COLOMN)), 0f);

    }
}
