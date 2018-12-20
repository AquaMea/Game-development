using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject[] inventory = new GameObject[10];

    public void AddItem(GameObject item)
    {
        bool itemAdded = false;

        for (int i = 0; i < inventory.Length; i++)
        {
            if(inventory[i] == null)
            {
                inventory[i] = item;
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
}
