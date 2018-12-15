using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camarafollow : MonoBehaviour {

    private GameObject player;
    private float pX;
    private float pY;

    private Vector2 currentVelocity;

    public float smoothX;
    public float smoothY;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        else
        {
            SmoothCamera();
        }
                
	}

    void SmoothCamera()
    {
        pX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref currentVelocity.x, smoothX);
        pY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref currentVelocity.y, smoothX);
        transform.position = new Vector3(pX, pY, transform.position.z);
    }
}
