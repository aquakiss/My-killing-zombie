using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	private float Timer;
	public float maxSpeed = 100f;

	void Awake() {
	}
	
	void FixedUpdate() {
	} 

		
		float spawnTime = 5f; // La quantité de temps entre chaque ponte.
		float spawnDelay = 3f; // La quantité de temps avant la ponte commence.
		public GameObject[] ennemies; // Tableau de préfabriqués ennemis.
			
		void annulerStart()
		{
			// Commencer à appeler la fonction Spawn plusieurs reprises après un délai.
			InvokeRepeating ("Spawn", spawnDelay, spawnTime);
		}
		
	    void Spawn()
		{
			// Instancier un ennemi aléatoire.
		int enemyIndex = Random.Range (0, ennemies.Length);
		Instantiate( ennemies[enemyIndex], transform.position, transform.rotation);
		}


}