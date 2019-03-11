using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour {

    public float fallMultiplier = 2.5f; //Creates a variable for the fall multiplier which can be edited in unity
    public float lowJumpMultiplier = 2f; //Creates a variable for the fall multiplier which can be edited in unity

    Rigidbody2D rb; //Creates a variable for the 2D Rigidbody component

    //Method gets the rigidbody component when the game starts
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        if (rb.velocity.y < 0) //if the character reaches the peak of their jump, then gravity is intensified using the fall multiplier to make the character fall faster
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump")) //if the player presses the jump button, the height of the jump will depend on how quickly the jump button is pressed
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }

		
	}
}
