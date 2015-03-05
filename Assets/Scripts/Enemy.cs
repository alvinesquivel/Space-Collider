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

		if (transform.position.y <= -10){
			SetPositionAndSpeed();


		}

		}
		
	public void SetPositionAndSpeed()
	{
		currentSpeed = Random.Range (MinSpeed, MaxSpeed);
		x = Random.Range (-7.80f, 7.80f);
		z = 0f;
		y = 10.0f;
		
		transform.position = new Vector3 (x, y, z);
	}
		
	#endregion
}

