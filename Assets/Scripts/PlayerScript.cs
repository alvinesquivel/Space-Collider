using UnityEngine;
using System.Collections;




public class PlayerScript : MonoBehaviour {

	enum State
	{
		Playing,
		Explosion,
		Invincible
	}
	
	private State state = State.Playing;


	public float maxSpeed = 5f;
	public GameObject LaserPrefab;
	public GameObject ExplosionPrefab;
	public static int Score = 0;
	public static int Lives = 3;
	public float xMin, xMax, yMin, yMax;
	private float InvisibleTime = 1.5f;
	private float MoveToScreen = 5;
	private float blinkRate = .1f;
	private int numberOfTimesToBlink = 10;
	private int blinkCount;




	void Update()
	{
		if (state != State.Explosion) {
						Vector3 pos = transform.position;

						pos.x += Input.GetAxis ("Horizontal") * maxSpeed * Time.deltaTime;

						pos.y += Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime;

						transform.position = pos;

						if (pos.x > xMax) {
								pos.x = xMax;
								transform.position = pos;
						}

						if (pos.x < xMin) {
								pos.x = xMin;
								transform.position = pos;
						}

						if (pos.y > yMax) {
								pos.y = yMax;
								transform.position = pos;
				
						}

						if (pos.y < yMin) {
								pos.y = yMin;
								transform.position = pos;
						}


						if (Input.GetKeyDown ("space")) {
								Instantiate (LaserPrefab, transform.position, transform.rotation);

						}
			}
	
	}



	void OnGUI()
	{
		BuildUI ();
	}

	void BuildUI()
	{
		GUI.Label (new Rect(80, 10, 100, 20), "Score: " + PlayerScript.Score.ToString());
		GUI.Label (new Rect(80, 30, 60, 20), "Lives: " + PlayerScript.Lives.ToString());

	}

	void OnTriggerEnter(Collider otherObject)
	{
		if (otherObject.CompareTag ("enemy") && state == State.Playing)
		{

			PlayerScript.Lives--;

			Enemy enemy = (Enemy)otherObject.gameObject.GetComponent ("Enemy");
			enemy.SetPositionAndSpeed();


			

			StartCoroutine(DestroyShip());

		}
	}

	IEnumerator DestroyShip()
	{
		state = State.Explosion;
		Instantiate (ExplosionPrefab, transform.position, Quaternion.identity);
		gameObject.renderer.enabled = false;
		transform.position = new Vector3 (0f, -7f, 0f);
		yield  return new WaitForSeconds (InvisibleTime);
		if (PlayerScript.Lives > 0) 
		{
			gameObject.renderer.enabled = true;

			while (transform.position.y < -7)
			{
				float amtToMove = MoveToScreen * Time.deltaTime;
				transform.position = new Vector3(0f, transform.position.y + amtToMove, transform.position.z);

				yield return 0;
			}
			state = State.Invincible;

			while (blinkCount < numberOfTimesToBlink)
			{
				gameObject.renderer.enabled = !gameObject.renderer.enabled;

				if (gameObject.renderer.enabled == true)
					blinkCount++;

				yield return new WaitForSeconds(blinkRate);
			}
			blinkCount = 0;
			state = State.Playing;
		} 
		else
			Application.LoadLevel (2);
			

	}


}
