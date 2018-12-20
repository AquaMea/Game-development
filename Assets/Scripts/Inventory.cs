using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public GameObject[] inventory = new GameObject[10];
    public Button[] InventoryButtons = new Button[10];

    public void AddItem(GameObject item)
    {
        bool itemAdded = false;

        for (int i = 0; i < inventory.Length; i++)
        {
            if(inventory[i] == null)
            {
                inventory[i] = item;
                //update UI
                InventoryButtons[i].image.overrideSprite = item.GetComponent<SpriteRenderer>().sprite;
                Debug.Log(item.name + " was added");
                itemAdded = true;
                //Do something with the obj
                item.SendMessage("DoInteraction");
                break;
            }
        }

        if (!itemAdded)
        {
            Debug.Log("inv is full");
        }
    }
    public bool FindItem(GameObject item)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if(inventory[i] == item)
            {
                return true;
            }
        }
        return false;
    }
    public GameObject FindItemByType(string itemType)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] != null)
            {
                if (inventory[i].GetComponent<InteractionObject>().itemType == itemType)
                {
                    return inventory[i];
                }
            }
        }
        return null;
    }

    public void RemoveItem(GameObject item)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] != null)
            {
                if (inventory[i] == item)
                {
                    //remove item from inventory
                    inventory[i] = null;
                    Debug.Log(item.name + " was remove from the inventory");
                    //remove inventory image
                    InventoryButtons[i].image.overrideSprite = null;

                    break;
                }
            }
        }
    }
}
