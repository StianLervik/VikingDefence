using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public int playerSpeed;
	public int airSpeed;
	public int jumpStrength;
	public int maxSpeed;

	private Rigidbody2D body;
	private Vector2 rayBox;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		rayBox = new Vector2 (0.9f, 0.9f);
	}

	void FixedUpdate (){
		float horizontal = Input.GetAxis ("Horizontal");

		RaycastHit2D hit = Physics2D.BoxCast (transform.position, rayBox, 0.0f, -transform.up, 0.12f, ~1<<5);
		if (hit) {
			Vector2 movement = new Vector2 (horizontal * playerSpeed, body.velocity.y);
			if (body.velocity.x < maxSpeed) {
				body.AddForce (movement);
			}
			if (Input.GetKey ("w") && hit.transform.tag == "Ground") {
				body.AddForce (transform.up * jumpStrength);
			}
		} else {
			Vector2 movement = new Vector2 (horizontal * airSpeed, body.velocity.y);
			if (body.velocity.magnitude < maxSpeed) {
				body.AddForce (movement);
			}
		}
	}
}
