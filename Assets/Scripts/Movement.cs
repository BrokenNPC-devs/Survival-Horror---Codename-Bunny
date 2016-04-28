using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    float move = 0;
    public float walkSpeed = 10;
    bool facingLeft = true;
    Rigidbody2D rb;

    //flips the sprite depending on which way it is moving
    void Flip() {
        //character is no longer facing right
        facingLeft = !facingLeft;  
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        //reverse axis
        transform.localScale = theScale; 
    }

	// Use this for initialization
	void Start() {
        //for ease of writing
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update() {
        move = Input.GetAxisRaw( "Horizontal");

        if (move > 0 && facingLeft)
            Flip();
        if (move < 0 && !facingLeft)
            Flip();

        if (HideBehind.playerIsHiding == true)
        {
            move = 0;
        }
	}

    //use for RigidBody physics
    void FixedUpdate() {
        rb.velocity = new Vector2(move * walkSpeed, 0);
    }
}
