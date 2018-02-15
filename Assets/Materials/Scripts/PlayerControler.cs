/* Magnus Crooke
 * 2-12-18
 * This code is responsible for your player, pickups, text updates, and more.
 */ 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour {

	public float speed; // Sets a constant speed for the player
	public Text countText; // Creates a text to keep score
	public Text winText; // Displays a text to inform the player when they have won

	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0; // Sets the counter at zero
		SetCountText (); // Updates the score
		winText.text = ""; // Displays a win statement when the player has won
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal"); // Moves the player
		float moveVertical = Input.GetAxis ("Vertical"); // Moves the player

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false); // Deactivates a pick up when collided with
			count = count + 1; // Adds a point when the a pick up is collided with
			SetCountText (); // Displays updated score
		}
		else if (other.gameObject.CompareTag ("Level 2 Pick Up"))
		{
			other.gameObject.SetActive (false); // Deactivates a pick up when collided with
			count = count + 5; // Adds five points when the a pick up is collided with
			SetCountText (); // Displays updated score
	}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		
			if (count >= 22) // When the score is equal to 22 then a win statement will be displayed
				
				winText.text = "You Win!"; // Displays when the player has collected all of the pick ups
		}

}