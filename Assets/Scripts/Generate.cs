using UnityEngine;

public class Generate : MonoBehaviour
{
	public GameObject rocks;
	int score = 0;
	int record;

	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}

	void OnGUI () 
	{
		GUI.color = Color.white;
		GUILayout.Label (" Счёт: " + score.ToString ());
		GUILayout.Label (" Рекорд: " + record.ToString ());
	}
	
	void CreateObstacle()
	{
		Instantiate (rocks);
		score++;
	}

	void Update () {
	if (score > record) {
		PlayerPrefs.SetInt ("savescore", score);
		PlayerPrefs.Save ();
		Debug.Log ("Save");
	}
	record = PlayerPrefs.GetInt ("savescore");
}
}