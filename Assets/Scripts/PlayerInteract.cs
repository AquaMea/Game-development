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
