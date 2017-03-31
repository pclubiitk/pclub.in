/// <summary>
/// Add force. this script will adding force to itself when start.
/// </summary>
using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour
{
	public Vector3 Force;
	public bool RandomForce;
	public Vector3 TurqueForce;
	public bool RandomTurque;
	
	void Start ()
	{
		if (!GetComponent<Rigidbody>())
			return;
		if (RandomForce) {
			Force = new Vector3 (Random.Range (-Force.x, Force.x), Random.Range (-Force.y, Force.y), Random.Range (-Force.z, Force.z));
		}
		this.GetComponent<Rigidbody>().AddForce (Force);
		if (RandomTurque) {
			TurqueForce = new Vector3 (Random.Range (-TurqueForce.x, TurqueForce.x), Random.Range (-TurqueForce.y, TurqueForce.y), Random.Range (-TurqueForce.z, TurqueForce.z));
		}
		this.GetComponent<Rigidbody>().AddTorque (TurqueForce);
	}
}
