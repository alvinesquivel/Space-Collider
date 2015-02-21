using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{


	#region Fields
	public float MinSpeed;
	public float MaxSpeed;
	private float currentSpeed;
	private float x, y, z;

	#endregion
	


	#region Properties

	#endregion





	#region Functions
		// Use this for initialization
		void Start ()
		{
		SetPositionAndSpeed();

		}

	
		// Update is called once per frame
		void Update ()
		{
		float amntToMove = currentSpeed * Time.deltaTime;
		transform.Translate (Vector3.down * amntToMove);

		if (transform.position.z <= -2){
			SetPositionAndSpeed();

		}

		}
		
	void SetPositionAndSpeed()
	{
		currentSpeed = Random.Range (MinSpeed, MaxSpeed);
		x = Random.Range (-6f, 6f);
		z = 20.0f;
		y = 0.0f;
		
		transform.position = new Vector3 (x, y, z);
	}
		
	#endregion
}

