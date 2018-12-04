using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGrab : MonoBehaviour {

    public bool grabbing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Grabable"){
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            GetComponent<Rigidbody>().useGravity = false;
            grabbing = true;

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Grabable")
        {
            grabbing = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        grabbing = false;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
