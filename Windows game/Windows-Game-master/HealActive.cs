using UnityEngine;
using System.Collections;

public class HealActive : MonoBehaviour {

	public int HPFill = 100;
	
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other) {
        var air = other.GetComponent<Collider>().gameObject.GetComponent<DamageManager>();
		if(air){
			air.HP += HPFill;	
		}
    }
}
