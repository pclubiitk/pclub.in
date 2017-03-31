/// <summary>
/// AI controller script
/// </summary>

using UnityEngine;
using System.Collections;

public enum AIState
{
	Idle,
	Patrol,
	Attacking,
	TurnPosition,
}

public enum TargetBehavior
{
	Static,
	Moving,
	Flying,
}

// add all necessary components.
[RequireComponent(typeof(FlightSystem))]

public class AIController : MonoBehaviour
{
	
	public string[] TargetTag;// list of Tags that AI will attack to
	public GameObject Target;// current target object.
	public float TimeToLock;// dularion to select the target
	public float AttackDirection = 0.5f;// direction that AI can see the target, aim (0 - 1) e.g. if  0  AI will see all direction.
	public float DistanceLock = float.MaxValue;// target lock distance
	public float DistanceAttack = 300;// attack distance
	public Vector3 BattlePosition; // middle of battle area position
	public BattleCenter CenterOfBattle; //  middle of battle area object (optional)
	public float FlyDistance = 1000;// limited distance between (BattlePosition and AI position) , this is will create a circle battle area and AI cannot go far out of this area.
	
	
	public AIState AIstate = AIState.Patrol;// AI state
	
	[HideInInspector]
	public int WeaponSelected = 0;
	public int AttackRate = 80; // (0 - 100) e.g. if 100 this AI will always shooting.
	
	private float timestatetemp;
	private float timetolockcount;
	private FlightSystem flight;// Core plane system
	private bool attacking;
	private Vector3 directionTurn;
	private TargetBehavior targetHavior;// current target behavior
	private Vector3 targetpositionTemp;
	
	void Start ()
	{
		timetolockcount = Time.time;
		flight = this.GetComponent<FlightSystem> ();// get Flight System
		flight.AutoPilot = true;// set auto pilot to true will make this plane flying and looking to Target automatically
		timestatetemp = 0;
		if(!CenterOfBattle){
			BattleCenter btcenter = (BattleCenter)GameObject.FindObjectOfType(typeof(BattleCenter));
			if(btcenter!=null)
			CenterOfBattle = btcenter.gameObject.GetComponent<BattleCenter>();
		}
	}
	
	void TargetBehaviorCal ()
	{
		// check the target is exist 
		if (Target) {
			// check if Target on move or static
			Vector3 delta = (targetpositionTemp - Target.transform.position);
			// check height from the target.
			float deltaheight = Mathf.Abs (targetpositionTemp.y - Target.transform.position.y); 
			targetpositionTemp = Target.transform.position;
			
			if (delta == Vector3.zero) {
				// Static target
				targetHavior = TargetBehavior.Static;	
			} else {
				// Movine target
				targetHavior = TargetBehavior.Moving;
				// Flying target
				if (deltaheight > 0.5f) {
					targetHavior = TargetBehavior.Flying;	
				}
			}
		}
		if(CenterOfBattle && CenterOfBattle.FixedFloor){
			if(flight.PositionTarget.y < BattlePosition.y){
				flight.PositionTarget.y = BattlePosition.y;
			}
		}
	}
	
	private float dot;
	
	
	void Update ()
	{
		if (!flight)
			return;
		

		if (CenterOfBattle) 
			// CenterOfBattle is exist , BattlePosition = CenterOfBattle position 
			//in case of able you to changing the battle area
			BattlePosition = CenterOfBattle.gameObject.transform.position;
		
		// calculate target behavior.
		TargetBehaviorCal ();
		
		// AI state machine
		switch (AIstate) {
		case AIState.Patrol:// AI will free flying and looking for a target.
			for (int t = 0; t<TargetTag.Length; t++) {
				// Find only gameobject by Tag within TargetTag[]
				if (GameObject.FindGameObjectsWithTag (TargetTag [t]).Length > 0) {
					// get all objects as same tag as TargetTag[i]
					GameObject[] objs = GameObject.FindGameObjectsWithTag (TargetTag [t]);
					float distance = int.MaxValue;
					for (int i = 0; i < objs.Length; i++) {
						if (objs [i]) {
							// make it delay by TimeToLock
							if (timetolockcount + TimeToLock < Time.time) {
                           	
								float dis = Vector3.Distance (objs [i].transform.position, transform.position);
								// selected closer target
								if (DistanceLock > dis) {
									if (!Target) {
										// i random a bit because i want this AI look hesitate. so you can remove "Random.Range (0, 100) > 80" if you want this AI select every target.
										if (distance > dis && Random.Range (0, 100) > 80) {
											distance = dis;
											Target = objs [i];
											flight.FollowTarget = true;
											// go to Attacking state
											AIstate = AIState.Attacking;
											// save current time
											timestatetemp = Time.time;
											// random weapon from the flight.WeaponControl.WeaponLists
											WeaponSelected = Random.Range (0, flight.WeaponControl.WeaponLists.Length);	
										}
									}
								}
							}
							// shooting..
							shootTarget (objs [i].transform.position);
						}
					}
				}
			}
			break;
		case AIState.Idle:// Free state
			// free fly and checking the AI is in of Battle Area 
			if (Vector3.Distance (flight.PositionTarget, this.transform.position) <= FlyDistance) {
				// go back to Patrol state
				AIstate = AIState.Patrol;
				timestatetemp = Time.time;
			}
			
			break;
		case AIState.Attacking:// Attacking state
			if (Target) {
				// if target is exist , Position target = target position
				flight.PositionTarget = Target.transform.position;
				// shoot the target..
				if (!shootTarget (flight.PositionTarget)) {
					
					if (attacking) {
						// if in attacking but cannot shoot anymore turn back in 5 sec
						if (Time.time > timestatetemp + 5) {
							turnPosition ();
						}	
					} else {
						// if no attacking turn back in 7 sec
						if (Time.time > timestatetemp + 7) {
							turnPosition ();
						}		
					}
				}
				
			} else {
				// if target is Destroyed go back to Patrol state
				AIstate = AIState.Patrol;
				// save current time
				timestatetemp = Time.time;
			}
			// if going out of the Battle Area. Go back to the center (BattlePosition)
			if (Vector3.Distance (BattlePosition, this.transform.position) > FlyDistance) {
				gotoCenter ();
			}
			break;
		case AIState.TurnPosition:// Turn back state
			if (Time.time > timestatetemp + 7) {
				//try to turn to attacking again after 7 sec in case of Target still alive but you just turning out of shooting range
				timestatetemp = Time.time;
				AIstate = AIState.Attacking;
			}
			// if going out of the Battle Area. Go back to the center (BattlePosition)
			if (Vector3.Distance (BattlePosition, this.transform.position) > FlyDistance) {
				gotoCenter ();
			}
			
			// current target height Y
			float height = flight.PositionTarget.y;
			if (targetHavior == TargetBehavior.Static) {// if static target
				directionTurn.y = 0;
				// calculate Position of bullet Drop and speed. try to make it accuracy
				flight.PositionTarget += (this.transform.forward + directionTurn) * flight.Speed;
				flight.PositionTarget.y = height;
				flight.PositionTarget.y += flight.Speed/2;
			} else {
				// calculate Position of bullet Drop and speed. try to make it accuracy
				flight.PositionTarget += (this.transform.forward + directionTurn) * flight.Speed;
				flight.PositionTarget.y = height;
				flight.PositionTarget.y += flight.Speed/2;
				//flight.PositionTarget = BattlePosition + new Vector3 (Random.Range (-FlyDistance, FlyDistance), Random.Range (0, FlyDistance / 2), Random.Range (-FlyDistance, FlyDistance));	
			}
			break;
		}
	}
	
	bool shootTarget (Vector3 targetPos)
	{
		// Shooting ...
		// checking direction between Target and AI 
		Vector3 dir = (targetPos - transform.position).normalized;
		dot = Vector3.Dot (dir, transform.forward);
		// checking distance between Target and AI
		float distance = Vector3.Distance (targetPos, this.transform.position);	
		
		if (distance <= DistanceAttack) {// is in Range ?
			// Ok in range
			
			if (dot >= AttackDirection) {// is in Direction ?
				// Ok Can Shoot them.
				
				attacking = true;
				if (Random.Range (0, 100) <= AttackRate) {// Make it delay and unstable shooting by Attack rate (if you set Attack Rate to 100 this AI will alway shooting like a brutal)
					flight.WeaponControl.LaunchWeapon (WeaponSelected);// FIRE A GUN!!!
				}
				if (distance < DistanceAttack / 3) {// if too close the target , let's turning back a while.
					turnPosition ();	
				}
				
			} else {
				
				// cannot shoot.
				// random weapon in flight.WeaponControl.WeaponLists
				WeaponSelected = Random.Range (0, flight.WeaponControl.WeaponLists.Length);	
				return false;
			}
		} else {
			// cannot shoot. the target is too far!! let moving faster!! 
			flight.SpeedUp ();
		}
		return true;
	}

	void turnPosition ()
	{
		// random a direction to turn some way
		directionTurn = new Vector3(Random.Range(-2,1)+1,Random.Range(-2,1)+1,Random.Range(-2,1)+1);
		AIstate = AIState.TurnPosition;
		// save current time.
		timestatetemp = Time.time;
		// disable attack
		attacking = false;
	}

	void gotoCenter ()
	{
		// go to Center of battle area
		flight.PositionTarget = BattlePosition;	
		// save current timne.
		timestatetemp = Time.time;
		// cancel a target.
		Target = null;
		AIstate = AIState.Idle;	
	}

}
