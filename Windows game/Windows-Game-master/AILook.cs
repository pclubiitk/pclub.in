/// <summary>
/// AI look. this script using as Terrent AI
/// </summary> 
using UnityEngine;
using System.Collections;

// add all necessary components.
[RequireComponent(typeof(WeaponController))]

public class AILook : MonoBehaviour {
	public string[] TargetTag = new string[1]{"Enemy"};// this AI will only shooting an objects are as same tag as within TargetTag[].
	private int indexWeapon;
	private GameObject target;
	private WeaponController weapon;
	private float timeAIattack;
	
	void Start () {
		//define a weapon controller.
		weapon = (WeaponController)this.GetComponent<WeaponController>();
	}
	
	
	void Update () {
		// if target is exist.
		if(target){
			// rotation facing to the target.
			Quaternion targetlook = Quaternion.LookRotation(target.transform.position - this.transform.position);
			this.transform.rotation = Quaternion.Lerp(this.transform.rotation,targetlook,Time.deltaTime * 3);
			// find a direction from the target
			Vector3 dir = (target.transform.position - transform.position).normalized;
            float direction = Vector3.Dot(dir, transform.forward);
			// check if in front direction
			if(direction>0.9f){
				if(weapon){
					// shooting!!.
					weapon.LaunchWeapon(indexWeapon);
				}
			}
			// AI attack the target for a while (3 sec)
			if(Time.time > timeAIattack+3){
				target = null;	
				// AI forget this target and try to looking new target
			}
		}else{
			for(int t=0;t<TargetTag.Length;t++){
			// AI find target only in TargetTag list
            if (GameObject.FindGameObjectsWithTag(TargetTag[t]).Length > 0)
            {
				// find all objects in Tags list.
                GameObject[] objs = GameObject.FindGameObjectsWithTag(TargetTag[t]);
                float distance = int.MaxValue;
                for (int i = 0; i < objs.Length; i++)
                {
					// find the distance from the target.
					float dis = Vector3.Distance(objs[i].transform.position, transform.position);
                    // check if in ranged.
                    if (distance > dis)
                    {
						// Select closer target
                        distance = dis;
                        target = objs[i];
						if(weapon){
							// random weapons
							indexWeapon = Random.Range(0,weapon.WeaponLists.Length);
						}
						timeAIattack = Time.time;
					}
				}
			}
			}	
		}
	}
}
