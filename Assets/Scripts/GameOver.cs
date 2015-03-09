using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour
{
	private int buttonWidth = 100;
	private int buttonHeight = 30;
		// Use this for initialization
	void OnGUI ()
	{
		GUI.Label (new Rect (300, 120, 200, 100), "Game Over!");
		GUI.Label (new Rect (300, 140, 200, 100), "Your Score: " +PlayerScript.Score);
		if (GUI.Button (new Rect ((Screen.width / 2 - buttonWidth / 2),
		                          Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight), "Play Again")) 
		{
			PlayerScript.Score = 0;
			PlayerScript.Lives = 3;
			Application.LoadLevel(1);
			
		}
	}
}

