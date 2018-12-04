using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJump : MonoBehaviour {

    private Rigidbody rb;
    public float thrust;
    public bool grounded = true;
    public playerGrab playergrab;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
        playergrab = GetComponent<playerGrab>();

    }
	
	// Update is called once per frame
	void Update () {
        if (playergrab.enabled){
            grounded = true;
        }
       
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.useGravity = true;
            rb.AddForce(Vector3.up * thrust, ForceMode.Impulse);
        }
       
    }

    void OnCollisionStay()
    {
        grounded = true;
    }

    void OnCollisionExit()
    {
        grounded = false;
    }
}
