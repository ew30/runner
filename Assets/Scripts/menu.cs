﻿using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	public Texture2D backgraund;
	public GUISkin MenuSkin;
	private int _window = 0;
	
	void  OnGUI (){ 
		GUI.skin = MenuSkin;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgraund);
		
		if (_window == 0) { 
			GUI.Box ( new Rect(Screen.width/2 - 100,Screen.height/2 - 100,200,180), "Основное меню"); 
			if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 - 80,180,30), "Играть")) { 
				Application.LoadLevel (1); 
			} 
			if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 - 40,180,30), "Настройки")) { 
				_window = 2; 
			} 

			if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 + 40,180,30), "Выход")) { 
				Application.Quit(); 
			} 
		}

		if (_window == 2) { 
			GUI.Box ( new Rect(Screen.width/2 - 100,Screen.height/2 - 100,200,180), "Настройки"); 
			GUI.Label ( new Rect(Screen.width/2 - 100,Screen.height/2 - 80,180,140), "Здесь пока ничего нет"); 
			if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 + 40,180,30), "Back") || Input.GetKey ("escape")) { 
				_window = 0; 
			} 
		}
	}
}