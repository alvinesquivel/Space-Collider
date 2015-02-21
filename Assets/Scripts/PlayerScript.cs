using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float maxSpeed = 5f;
	public GameObject LaserPrefab;

	void Update(){
		Vector3 pos = transform.position;
		pos.x += Input.GetAxis ("Horizontal") * maxSpeed * Time.deltaTime;
		pos.z += Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime;


		transform.position = pos;
		if (Input.GetKeyDown ("space")) {
			Instantiate (LaserPrefab, transform.position, transform.rotation);		
		}

	}
}
