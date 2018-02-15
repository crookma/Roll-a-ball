using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour {


	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position; // Responble for the camera position over the player
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset; // Responble for the camera position over the player
	}
}
