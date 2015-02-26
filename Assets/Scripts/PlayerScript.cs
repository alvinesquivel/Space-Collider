using UnityEngine;
using System.Collections;




public class PlayerScript : MonoBehaviour {

	public float maxSpeed = 5f;
	public GameObject LaserPrefab;
	public GameObject ExplosionPrefab;
	public static int Score = 0;
	public static int Lives = 3;
	public static int Missed = 0;
	public float xMax, yMin, yMax;
	float playerRadius = 0.5f;



	void Update()
	{

		Vector3 pos = transform.position;

		pos.x += Input.GetAxis ("Horizontal") * maxSpeed * Time.deltaTime;

		pos.y += Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime;

		transform.position = pos;

		if (pos.x+playerRadius > xMax)
		{
			pos.x = xMax - playerRadius;
			transform.position = pos;
		}

		if (pos.x + playerRadius < -xMax) 
		{
			pos.x = -xMax + playerRadius;
			transform.position = pos;
		}



		if (Input.GetKeyDown ("space")) 
		{
			Instantiate (LaserPrefab, transform.position, transform.rotation);

		}
	
	}



	void OnGUI()
	{
		BuildUI ();
	}

	void BuildUI()
	{
		GUI.Label (new Rect(10, 10, 100, 20), "Score: " + PlayerScript.Score.ToString());
		GUI.Label (new Rect(190, 10, 60, 20), "Lives: " + PlayerScript.Lives.ToString());

	}

	void OnTriggerEnter(Collider otherObject)
	{
		if (otherObject.CompareTag ("enemy"))
		{

			PlayerScript.Lives--;

			Enemy enemy = (Enemy)otherObject.gameObject.GetComponent ("Enemy");
			enemy.SetPositionAndSpeed();


			

			StartCoroutine(DestroyShip());

		}
	}

	IEnumerator DestroyShip()
	{
		Instantiate (ExplosionPrefab, transform.position, Quaternion.identity);
		gameObject.renderer.enabled = false;
		transform.position = new Vector3 (0f, -7f, 0f);
		yield  return new WaitForSeconds (1.5f);
		gameObject.renderer.enabled = true;

	}


}
