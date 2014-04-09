using UnityEngine;
using System.Collections;

//[System.Serializable]

public class MoveEnnemiScript : MonoBehaviour {

	public float maxSpeed = 110f;
	//private int Vie = 1;
    //private int Degat = 1;
	//private bool dead = false;			// Whether or not the enemy is dead.
	//private Transform frontCheck;		// Reference to the position of the gameobject used for checking if something is in front.
	//public Sprite deadEnemy;			// A sprite of the enemy when it's dead.
	//public Sprite damagedEnemy;			// An optional sprite of the enemy when it's damaged.

	public Vector2 speed = new Vector2(10, 10);
	public Vector2 direction = new Vector2(-1, 0);	
	public Vector2 invdirection = new Vector2(1, 0);
	//private Vector2 movement;
	//private Vector2 movements;

	Vector3 _depart;
	Vector3 _target;
	float _t;
	
	void Update()
	{
		transform.position = Vector3.Lerp(_depart, _target, _t);
		_t += Time.deltaTime; //Take 2 seconds
	}
	
	public void SetTargetPosition(Vector3 newTargetPosition)
	{
		_depart = transform.position;
		_target = newTargetPosition;
		_t = 0;
	}
	
	/*void FixedUpdate()
	{
		// Application du mouvement
		rigidbody2D.velocity = movement;
	}*/

		void OnTriggerEnter2D (Collider2D col)
		{
			if (col.gameObject.tag == "Player") {
			print ("collision avec player");
			//rigidbody2D.velocity = movements;
		} else if (col.gameObject.tag == "laby") {
			print ("j'ai toucher un mur");
			//this.gameObject.transform.rotation;
			}
		}

}

	
