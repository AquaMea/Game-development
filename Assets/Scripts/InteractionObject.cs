using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{

	public bool inventory; //if true object can be added to inventory
    public bool openable; //if true object can be opened
    public bool locked; //if true object can be locked
    public bool examine = true; //if true object can be examined
    public bool talk; //if true can be talked to
    public string itemType; //Type of item

    public GameObject itemNeeded;
    public string message;
    public string description;

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

    public void Talk()
    {
        Debug.Log(talk);
    }

    public void Examine()
    {
        Debug.Log(examine);
    }
}
