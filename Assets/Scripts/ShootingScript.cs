using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {

	public float fireDelay = 0.25f;
	float cooldownTimer = 0f;

	void Update () {
		cooldownTimer -= Time.deltaTime;

			if (Input.GetButton ("Fire1") && cooldownTimer <= 0) {
			{
				Debug.Log ("Pew!");
				cooldownTimer = fireDelay;
			}
	}
}
}