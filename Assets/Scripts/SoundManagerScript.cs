using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

    public static AudioClip playerDeathSound, fireSound, jumpSound, enemyDeathSound; //creates static variables for each sound effect
    static AudioSource audioSrc; //creates a static variable for the audio source

	// Use this for initialization
	void Start () {
        //all sound effects are loaded
        playerDeathSound = Resources.Load<AudioClip>("PlayerDeath");
        enemyDeathSound = Resources.Load<AudioClip>("EnemyDeath");
        fireSound = Resources.Load<AudioClip>("Gun");
        jumpSound = Resources.Load<AudioClip>("Jump");

        //Gets the audio source component
        audioSrc = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

		
	}

    // This method plays the appropriate sound effect upon shooting, jumping, killing enemies, and player death using a switch statement
    public static void PlaySound (string clip)
    {
        switch (clip) {
            case "fire":
                audioSrc.PlayOneShot(fireSound);
                break;
            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "playerDeath":
                audioSrc.PlayOneShot(playerDeathSound);
                break;
            case "enemyDeath":
                audioSrc.PlayOneShot(enemyDeathSound);
                break;
        }
    }
}
