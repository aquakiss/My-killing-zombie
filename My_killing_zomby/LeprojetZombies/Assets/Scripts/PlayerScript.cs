using UnityEngine;
using System.Collections;

[System.Serializable]
	
public class PlayerScript : MonoBehaviour
{
	public float maxSpeed = 10f;
	/*public int vie = 2;
	///public float rotationVelo = 1f;

	void FixedUpdate()
	{
		float movehorizontal = Input.GetAxis ("Horizontal");
		float movevertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (movehorizontal, movevertical, 0);
		rigidbody2D.velocity = movement * maxSpeed;
	} */

	public Vector2 speed = new Vector2(100, 100);
	// 2 - Stockage du mouvement
	private Vector2 movement;
	
	void Update()
	{
		// 3 - Récupérer les informations du clavier/manette
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		
		// 4 - Calcul du mouvement
		movement = new Vector2(speed.x * inputX,speed.y * inputY * Time.deltaTime * 100);
	}
	
	void FixedUpdate()
	{
		// 5 - Déplacement
		rigidbody2D.velocity = movement;
	}
}
