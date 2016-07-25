using UnityEngine;
using System.Collections;

public class Jumpsound : MonoBehaviour {
	public AudioClip jump;

	void Start () {
	
	}
	

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) { 
			audio.PlayOneShot (jump);
		}
	}
}
