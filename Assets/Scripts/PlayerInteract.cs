using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

	GameObject currentInterObj = null;

	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("InteractableObject")){
			Debug.Log(other.name);
            currentInterObj = other.gameObject;
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
