using UnityEngine;
using System.Collections;

public class end : MonoBehaviour {
	
	public Texture2D backgraund;
	public GUISkin MenuSkin;
	private int _window = 0;
	
	void  OnGUI (){ 
		GUI.skin = MenuSkin;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgraund);
		
		if (_window == 0) { 
			GUI.Box ( new Rect(Screen.width/2 - 100,Screen.height/2 - 100,200,150), "Конец игры"); 
			if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 - 80,180,30), "Играть снова")) { 
				Application.LoadLevel (1); 
			} 
			if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 - 40,180,30), "Главное меню")) { 
				Application.LoadLevel (0); 
			} 
			if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 - 0,180,30), "Выход")) { 
				Application.Quit(); 
			} 
		}
	}
}