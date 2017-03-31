/// <summary>
/// Enemy spawner. auto Re-Spawning an Enemy by Random index of Objectman[]
/// </summary>
using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
	
	public bool Enabled = true;
	public GameObject[] Objectman; // object to spawn
	public float timeSpawn = 3;
	public int enemyCount = 10;
	public int radius = 10;
	public string Tag = "Enemy";
	public string Type = "Enemy";
	private float timetemp = 0;
	private int indexSpawn;
	
	void Start ()
	{
		indexSpawn = Random.Range (0, Objectman.Length);
		timetemp = Time.time;
	}

	void Update ()
	{
		
		if (!Enabled)
			return;
		
		
		var gos = GameObject.FindGameObjectsWithTag (Tag);
		if (gos.Length < enemyCount && Time.time > timetemp + timeSpawn) {
			// spawing an enemys by random index of Objectman[]
			timetemp = Time.time;
			GameObject obj = (GameObject)GameObject.Instantiate (Objectman [indexSpawn], transform.position + new Vector3 (Random.Range (-radius, radius), 0, Random.Range (-radius, radius)), Quaternion.identity);
			obj.tag = Tag;
			indexSpawn = Random.Range (0, Objectman.Length);
		}
	}
}
