using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyScript : MonoBehaviour {

    public GameObject blood;
    public float moveSpeed = 3f;
    
    Vector3 localScale;
    bool movingRight = true;
    Rigidbody2D rb;
    public PowerUp powerUpTemplate = null;


	// Use this for initialization
	void Start () {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D> ();
        

    }
	
	// Update is called once per frame
	void Update () {

        
        if (transform.position.x > GameObject.Find("Player").transform.position.x)
        {
            movingRight = false;
        }

        if (transform.position.x < GameObject.Find("Player").transform.position.x)
            movingRight = true;

        if (movingRight)
            moveRight();
        else
            moveLeft();


    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            ScoreScript.scoreValue += 10;
            SoundManagerScript.PlaySound("enemyDeath");
            Instantiate(blood, transform.position, Quaternion.identity);
            Destroy(col.gameObject);
            Destroy(gameObject);
            int powerUp = (Random.Range(0, 20));
            if (powerUp==7)
            {
                SpawnPowerUp();
            }
        }


    }

    void moveRight()
    {
        movingRight = true;
        localScale.x = 1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * moveSpeed, rb.velocity.y);
    }

    void moveLeft()
    {
        movingRight = false;
        localScale.x = -1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * moveSpeed, rb.velocity.y);
    }


    void SpawnPowerUp()
    {
        PowerUp powerUpClone = Instantiate(powerUpTemplate);

        powerUpClone.gameObject.SetActive(true);

        powerUpClone.transform.position = transform.position;
    }
}
