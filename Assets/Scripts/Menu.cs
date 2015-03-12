using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{

	private int buttonWidth = 100;
	private int buttonHeight = 30;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void OnGUI ()
		{
			
			if (GUI.Button (new Rect ((Screen.width / 2 - buttonWidth / 2),
		    	                 Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight), "Play Now")) 
			{
				Application.LoadLevel(1);
				
			}
			if (GUI.Button(new Rect ((Screen.width / 2 - buttonWidth / 2), (Screen.height / 2 - buttonHeight / 2 + 50), buttonWidth, buttonHeight), "Quit"))
			{
				Application.Quit();
			}
		}
		
}

