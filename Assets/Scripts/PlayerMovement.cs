using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float Speed;

    //private Vector2 direction;

    public Animator animator;

	// Update is called once per frame
	void Update ()
    {
        //Move();
        //GetInput();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"), 0.0f);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);


        transform.position = transform.position + movement * Time.deltaTime * Speed;
    }
}

    /*public void Move()
    {
        transform.Translate(direction*Speed*Time.deltaTime);
    }

private void GetInput()
{
    direction = Vector2.zero;

    if (Input.GetKey(KeyCode.W))
    {
        direction += Vector2.up;
    }
    if (Input.GetKey(KeyCode.A))
    {
        direction += Vector2.left;
    }
    if (Input.GetKey(KeyCode.S))
    {
        direction += Vector2.down;
    }
    if (Input.GetKey(KeyCode.D))
    {
        direction += Vector2.right;
    }
}
}*/
