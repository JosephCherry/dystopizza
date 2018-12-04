using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {


	public float speed;
    private Rigidbody rb;
    public playerGrab playergrab;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        playergrab = GetComponent<playerGrab>();
	}

    // Update is called once per frame

    void FixedUpdate()
    {

        if(playergrab.grabbing == false){
            float moveHorizontal = Input.GetAxisRaw("Horizontal");

            Vector3 movement = new Vector3(moveHorizontal, 0, 0);

            rb.AddForce(movement * speed);
        }

    }

}
