/// <summary>
/// Player controller.
/// </summary>
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(FlightSystem))]

public class PlayerController : MonoBehaviour
{
	
	FlightSystem flight;// Core plane system
	FlightView View;
	public bool Active = true;
	public bool SimpleControl;// make it easy to control Plane will turning easier.
	public bool Acceleration;// Mobile*** enabled gyroscope controller
	public float AccelerationSensitivity = 5;// Mobile*** gyroscope sensitivity
	private TouchScreenVal controllerTouch;// Mobile*** move
	private TouchScreenVal fireTouch;// Mobile*** fire
	private TouchScreenVal switchTouch;// Mobile*** swich
	private TouchScreenVal sliceTouch;// Mobile*** slice
	private bool directVelBack;
	public GUISkin skin;
	public bool ShowHowto;

	void Start ()
	{
		flight = this.GetComponent<FlightSystem> ();
		View = (FlightView)GameObject.FindObjectOfType (typeof(FlightView));
		
		
		// setting all Touch screen controller in the position
		controllerTouch = new TouchScreenVal (new Rect (0, 0, Screen.width / 2, Screen.height - 100));
		fireTouch = new TouchScreenVal (new Rect (Screen.width / 2, 0, Screen.width / 2, Screen.height));
		switchTouch = new TouchScreenVal (new Rect (0, Screen.height - 100, Screen.width / 2, 100));
		sliceTouch = new TouchScreenVal (new Rect (0, 0, Screen.width / 2, 50));
		
		if (flight)
			directVelBack = flight.DirectVelocity;
	}
	
	void Update ()
	{
		if (!flight || !Active)
			return;
		#if UNITY_EDITOR || UNITY_WEBPLAYER || UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX
		// On Desktop
		DesktopController();
		#else
		// On Mobile device
		MobileController ();
		#endif
		
	}
	
	void DesktopController ()
	{
		// Desktop controller
		flight.SimpleControl = SimpleControl;
		
		// lock mouse position to the center.
		MouseLock.MouseLocked = true;
		
		flight.AxisControl (new Vector2 (Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y")));
		if (SimpleControl) {
			flight.DirectVelocity = false;
			flight.TurnControl (Input.GetAxis ("Mouse X"));
		} else {
			flight.DirectVelocity = directVelBack;	
		}

		flight.TurnControl (Input.GetAxis ("Horizontal"));
		flight.SpeedUp (Input.GetAxis ("Vertical"));
		
		
		if (Input.GetButton ("Fire1")) {
			flight.WeaponControl.LaunchWeapon ();
		}
		
		if (Input.GetButtonDown ("Fire2")) {
			flight.WeaponControl.SwitchWeapon ();
		}
		
		if (Input.GetKeyDown (KeyCode.C)) {
			if (View)
				View.SwitchCameras ();	
		}	
	}
	
	void MobileController ()
	{
		// Mobile controller
		
		flight.SimpleControl = SimpleControl;
		
		if (Acceleration) {
			// get axis control from device acceleration
			Vector3 acceleration = Input.acceleration;
			Vector2 accValActive = new Vector2 (acceleration.x, (acceleration.y + 0.3f) * 0.5f) * AccelerationSensitivity;
			flight.FixedX = false;
			flight.FixedY = false;
			flight.FixedZ = true;
			
			flight.AxisControl (accValActive);
			flight.TurnControl (accValActive.x);
		} else {
			flight.FixedX = true;
			flight.FixedY = false;
			flight.FixedZ = true;
			// get axis control from touch screen
			Vector2 dir = controllerTouch.OnDragDirection (true);
			dir = Vector2.ClampMagnitude (dir, 1.0f);
			flight.AxisControl (new Vector2 (dir.x, -dir.y) * AccelerationSensitivity * 0.7f);
			flight.TurnControl (dir.x * AccelerationSensitivity * 0.3f);
		}
		sliceTouch.OnDragDirection (true);
		// slice speed
		flight.SpeedUp (sliceTouch.slideVal.x);
		
		if (fireTouch.OnTouchPress ()) {
			flight.WeaponControl.LaunchWeapon ();
		}	
		if (switchTouch.OnTouchPress ()) {
		
		}	
	}
	
	
	// you can remove this part..
	void OnGUI ()
	{
		if (!ShowHowto)
			return;
		
		if (skin)
			GUI.skin = skin;
		
		if (GUI.Button (new Rect (20, 150, 200, 40), "Gyroscope " + Acceleration)) {
			Acceleration = !Acceleration;
		}
		
		if (GUI.Button (new Rect (20, 200, 200, 40), "Change View")) {
			if (View)
				View.SwitchCameras ();	
		}
		
		if (GUI.Button (new Rect (20, 250, 200, 40), "Change Weapons")) {
			if (flight)
				flight.WeaponControl.SwitchWeapon ();
		}
		
		if (GUI.Button (new Rect (20, 300, 200, 40), "Simple Control " + SimpleControl)) {
			if (flight)
				SimpleControl = !SimpleControl;
		}
	}

}
