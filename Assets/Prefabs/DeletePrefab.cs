using UnityEngine;
using System.Collections;

public class DeletePrefab : MonoBehaviour {

	public float timer = 3f;
	void Start () {
		Destroy (gameObject, timer);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
