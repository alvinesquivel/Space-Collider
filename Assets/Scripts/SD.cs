﻿using UnityEngine;
using System.Collections;

public class SD : MonoBehaviour {
	public float timer = 3f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject , timer );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
