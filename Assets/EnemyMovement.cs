using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public int enemySpeed;

	private Rigidbody2D body;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate (){
		Vector2 movement = new Vector2 (-1 * enemySpeed, body.velocity.y);
		body.velocity = movement;
	}
}
