using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

	public GameObject currentInterObj = null;
    public InteractionObject currentInterObjScript = null;
    public Inventory inventory;

    void Update()
    {
        if(Input.GetButtonDown("Interact") && currentInterObj)
        {
            //Check to see if the object is to be store in the inventory
            if(currentInterObjScript.inventory)
            {
                inventory.AddItem(currentInterObj);
                currentInterObj = null;
            }
            //Check to see if can be opened
            if(currentInterObjScript.openable)
            {
                //Check to see if locked
                if (currentInterObjScript.locked)
                { 
                    //checking if the needed item is in the inventory
                    if (inventory.FindItem(currentInterObjScript.itemNeeded))
                    {
                        Debug.Log("Opening the door");
                        //Open the door
                        currentInterObjScript.locked = false;
                        currentInterObjScript.Open();
                    }
                    else
                    {
                        Debug.Log("U dont have the key");
                    }
                } else
                {
                    Debug.Log("Door is open");
                    //Door is already open close it
                }
            }
        }
    }

	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("InteractableObject")){
			Debug.Log(other.name);
            currentInterObj = other.gameObject;
            currentInterObjScript = currentInterObj.GetComponent<InteractionObject>();

        }
	}

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InteractableObject"))
        {
            if(other.gameObject == currentInterObj)
            {
                currentInterObj = null;
            } 
        }
    }
}
