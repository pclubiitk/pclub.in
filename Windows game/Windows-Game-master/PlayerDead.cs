using UnityEngine;
using System.Collections;

public class PlayerDead : FlightOnDead
{
	void Start (){}
	
	// if player dead 
	public override void OnDead (GameObject killer)
	{
		// if player dead call GameOver in GameManager
		GameManager gamemanger = (GameManager)GameObject.FindObjectOfType (typeof(GameManager));
		gamemanger.GameOver ();
		base.OnDead (killer);
	}
}
