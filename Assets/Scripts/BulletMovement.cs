using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	float maxSpeed = 10;

	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.y +=  maxSpeed * Time.deltaTime;
		transform.position = pos;
	}
}
