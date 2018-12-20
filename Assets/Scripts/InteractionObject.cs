using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{

	public bool inventory; //if true object can be added to inventory
    public bool openable;
    public bool locked;
    public GameObject itemNeeded;

    public Animator anim;

    public void DoInteraction()
    {
    	//Picked up and put in innvetory
        gameObject.SetActive(false);
    }

    public void Open()
    {
        anim.SetBool("Open", true);
    }
}
