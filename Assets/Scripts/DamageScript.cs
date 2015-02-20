using UnityEngine;
using System.Collections;

public class DamageScript : MonoBehaviour {
	public int health = 1;

	public float invulnPeriod = 0;
	float invulnTimer = 0;
	int correctlayer;

	void Start() {
		correctlayer = gameObject.layer;
	}



	void OnTriggerEnter2D() {
		Debug.Log ("Enemy Hit!");


			health--;
			invulnTimer = 0.50f;
			gameObject.layer = 10;

	}
	void Update(){
		invulnTimer -= Time.deltaTime;
		if (invulnTimer <= 0) {
			gameObject.layer = correctlayer;
		}
		if (health <= 0){

			Die();
	
		}
	}

	void Die() {
		Destroy (gameObject);
	}
}
