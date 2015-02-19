using UnityEngine;
using System.Collections;

public class MovingScript : MonoBehaviour {

	float maxSpeed = 5f;


	void Update(){
		Vector3 pos = transform.position;
		pos.x += Input.GetAxis ("Horizontal") * maxSpeed * Time.deltaTime;
		pos.y += Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime;
		transform.position = pos;


	}
}
