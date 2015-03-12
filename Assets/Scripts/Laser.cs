using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {
	public GameObject ExplosionPrefab;
	public float maxSpeed = 10;

	private Enemy enemy;



	void Start ()
	{
		enemy = (Enemy)GameObject.Find("Enemy").GetComponent ("Enemy");

			
	}	

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

		if (otherObject.tag == "enemy"){

			Instantiate (ExplosionPrefab, enemy.transform.position, enemy.transform.rotation);
			enemy.MinSpeed += .5f;
			enemy.MaxSpeed += .5f;

			enemy.SetPositionAndSpeed();

			Destroy (this.gameObject);

			PlayerScript.Score += 100;

		}



	}


}