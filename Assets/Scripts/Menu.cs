using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
	private string instructions = "How to play:\nPress Left and Right Arrows to move.\nPress Space bar to fire.\n";
	private int buttonWidth = 200;
	private int buttonHeight = 50;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void OnGUI ()
		{
			GUI.Label (new Rect(10, 10, 250, 200), instructions);
			if (GUI.Button (new Rect ((Screen.width / 2 - buttonWidth / 2),
		    	                 Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight), "Start Game")) 
			{
			Application.LoadLevel(1);
				
			}
		}
		
}

