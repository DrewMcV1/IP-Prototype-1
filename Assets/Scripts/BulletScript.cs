using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float velocityX = 5f;
    public float velocityY = 0f;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(velocityX, velocityY);
        Destroy(gameObject, 3f);


		
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Platform"))
        {                                   
            Destroy(gameObject);
        }
    }
}
