using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public bool aOn = false;
    public bool dOn = false;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
            
        rb.velocity = new Vector2(xInput*moveSpeed, yInput*moveSpeed);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("a"))
            transform.eulerAngles = new Vector3 (0, 0, 90);
            aOn = true;
            if(aOn = true && Input.GetKeyDown("w"))
                transform.eulerAngles = new Vector3 (0, 0, 50);
            if(aOn = true && Input.GetKeyDown("s"))
                transform.eulerAngles = new Vector3 (0, 0, 130);
        else
            aOn = false;
        if(Input.GetKeyDown("d"))
            transform.eulerAngles = new Vector3 (0, 0, -90);
            //zRot = zRot ;
        if(Input.GetKeyDown("s"))
            transform.eulerAngles = new Vector3 (0, 0, 180);
        if(Input.GetKeyDown("w"))
            transform.eulerAngles = new Vector3 (0, 0, 0);
        if(Input.GetKeyDown("a") && Input.GetKeyDown("w"))
            transform.eulerAngles = new Vector3 (0, 0, 50);
        if(Input.GetKeyDown("a") && Input.GetKeyDown("s"))
            transform.eulerAngles = new Vector3 (0, 0, 130);
        if(Input.GetKeyDown("d") && Input.GetKeyDown("w"))
            transform.eulerAngles = new Vector3 (0, 0, -50);
        if(Input.GetKeyDown("d") && Input.GetKeyDown("s"))
            transform.eulerAngles = new Vector3 (0, 0, -130);
    }
}
