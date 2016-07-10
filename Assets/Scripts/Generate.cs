using UnityEngine;

public class Generate : MonoBehaviour
{
	public GameObject rocks;
	int score = 0;

	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}

	void OnGUI () 
	{
		GUI.color = Color.white;
		GUILayout.Label(" Score: " + score.ToString());
	}
	
	void CreateObstacle()
	{
		Instantiate(rocks);
		score++;
	}
}