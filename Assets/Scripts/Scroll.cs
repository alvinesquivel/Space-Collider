using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour
{
	public float Speed;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
			float amtToMove = Speed * Time.deltaTime;
			transform.Translate (Vector3.down * amtToMove);

			if (transform.position.y < -25)
			{
			transform.position = new Vector3(transform.position.x, 38.55f, transform.position.z);
			}
		}
}

