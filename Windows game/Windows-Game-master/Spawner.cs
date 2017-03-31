/// <summary>
/// Spawner. this scripts just a spawner object.
/// </summary>
using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
	private Transform Objectman = null;// object to spawn 
	private float timeSpawn = 0;
	private int timeSpawnMax = 0;
	private float enemyCount = 0;
	public int radian = 0;

	private void Start ()
	{
		if (GetComponent<Renderer>())
			GetComponent<Renderer>().enabled = false;

	}

	private void Update ()
	{
		// find the spawned objects
		GameObject[] gos = GameObject.FindGameObjectsWithTag (Objectman.tag);
		timeSpawn += 1;
		if (gos.Length < enemyCount) {
			int timespawnmax = timeSpawnMax;
			if (timespawnmax <= 0) {
				timespawnmax = 10;
			}
			if (timeSpawn >= timespawnmax) {
				GameObject enemyCreated =
                    (GameObject)
                    Instantiate (Objectman,
                                transform.position +
                                new Vector3 (Random.Range (-radian, radian), 20, Random.Range (-radian, radian)),
                                Quaternion.identity);

				enemyCreated.transform.localScale = new Vector3 (Random.Range (5, 20), enemyCreated.transform.localScale.x,
                                                                enemyCreated.transform.localScale.x);

				timeSpawn = 0;

			}
		}

	}

}
