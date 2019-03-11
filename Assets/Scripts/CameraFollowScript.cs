using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour {

    public GameObject target; //Creates a variable called target

	// Use this for initialization
	void Start () {
		
	}
	
	// Updates the camera position to follow the player
	void Update () {

        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z); 
		
	}
}
