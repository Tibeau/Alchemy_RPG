using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> inventory = new List<InventoryItem>();
    private Dictionary<ItemData, InventoryItem> itemDictionary = new Dictionary<ItemData, InventoryItem>();


    private void OnEnable() {
        Flower.OnFlowerCollected += Add;
    }

       private void OnDisable() {
        Flower.OnFlowerCollected -= Add;
    }

    public void Add(ItemData itemData) {
        if(itemDictionary.TryGetValue(itemData, out InventoryItem item)) {
            item.AddToStack();
            Debug.Log($"{item.itemData.displayName} total stack is now {item.stackSize}");
        } else {
            InventoryItem newItem = new InventoryItem(itemData);
            inventory.Add(newItem);
            itemDictionary.Add(itemData, newItem);
             Debug.Log($"Added {itemData.displayName} to inventory");
        }
    }

    public void remove(ItemData itemData) {
         if(itemDictionary.TryGetValue(itemData, out InventoryItem item)) {
            item.RemoveFromStack();
            if (item.stackSize == 0) {
                itemDictionary.Remove(itemData);
            }
        } 
    }
}
