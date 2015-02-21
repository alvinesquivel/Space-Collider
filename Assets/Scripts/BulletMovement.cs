using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	public float maxSpeed = 10;

	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.z +=  maxSpeed * Time.deltaTime;
		transform.position = pos;

		if (gameObject.transform.position.z > 17) {
			Destroy (gameObject);		
		}
	}
}
