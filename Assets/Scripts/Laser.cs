using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {
	public GameObject ExplosionPrefab;
	public float maxSpeed = 10;

	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.y +=  maxSpeed * Time.deltaTime;
		transform.position = pos;

		if (gameObject.transform.position.y > 10) {
			Destroy (gameObject);		
		}

	}

	void OnTriggerEnter(Collider otherObject)
	{
		if (otherObject.CompareTag ("enemy")){

			Enemy enemy = (Enemy)otherObject.gameObject.GetComponent ("Enemy");
			Instantiate (ExplosionPrefab, enemy.transform.position, enemy.transform.rotation);
			enemy.SetPositionAndSpeed();

			Destroy (gameObject);
			PlayerScript.Score += 100;
		}
	}
}