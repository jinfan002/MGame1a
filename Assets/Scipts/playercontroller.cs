using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
  
    public Text countText;
    public Text wintext;
    public bool onGround;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        onGround = true;
       
    }
    void Update()
    {
        if (onGround == true)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector3(0f, 10f, 0f);
                onGround = false;
            }
        }
    }
        private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
        
    }
   
    void OnCollisionEnter(Collision any)
    {
        if (any.gameObject.CompareTag("Ground"))

        {
            onGround = true;
        }



    }
  
}
