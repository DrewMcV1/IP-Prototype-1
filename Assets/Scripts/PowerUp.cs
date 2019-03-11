using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUp : MonoBehaviour 
{
	
	public float speed = 0.01f;
	public float size =1f;
	float directionX = 0.0f;
    float directionY = 0.5f;
	public float timeLeft = 3.0f;
    public PlayerController player;
    

	public void OnCollisionEnter2D(Collision2D other)
	{
		
        if (other.gameObject.name == "Player")
        {

            player.fireRate = 0.1f;
            Destroy(gameObject);

        }
        
    }
		
	
	
	
}
