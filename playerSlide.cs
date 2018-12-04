using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSlide : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;
    public Animator anim;
    public bool isSliding;
    public bool stopSlide;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

            isSliding = true;
            float moveHorizontal = Input.GetAxisRaw("Horizontal");

            Vector3 movement = new Vector3(moveHorizontal, 0, 0);

            rb.AddForce(movement * speed, ForceMode.VelocityChange);

            if (Input.GetAxisRaw("Horizontal") > 0){
                anim.SetInteger("PlayerAnim", 1);
            }

            if (Input.GetAxisRaw("Horizontal") < 0)
            {
                Debug.Log("Left slide triggered");
                anim.SetInteger("PlayerAnim", 2);
            }

        }

        if(stopSlide){
            rb.velocity = Vector3.zero;
        }

        if (isSliding == false){
            stopSlide = false;
            anim.SetInteger("PlayerAnim", 0);
        }

    }
}
