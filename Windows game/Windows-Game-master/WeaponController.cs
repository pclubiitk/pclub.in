using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour
{
	public string[] TargetTag = new string[1]{"Enemy"};
	public WeaponLauncher[] WeaponLists;
	public int CurrentWeapon = 0;
	public bool ShowCrosshair;
	
	void Awake ()
	{
		// find all attached weapons.
		if (this.transform.GetComponentsInChildren (typeof(WeaponLauncher)).Length > 0) {
			var weas = this.transform.GetComponentsInChildren (typeof(WeaponLauncher));
			WeaponLists = new WeaponLauncher[weas.Length];
			for (int i=0; i<weas.Length; i++) {
				WeaponLists [i] = weas [i].GetComponent<WeaponLauncher> ();
				WeaponLists [i].TargetTag = TargetTag;
			}
		}
	}
	public WeaponLauncher GetCurrentWeapon(){
		if (CurrentWeapon < WeaponLists.Length && WeaponLists [CurrentWeapon] != null) {
			return WeaponLists [CurrentWeapon];
		}
		return null;
	}
	
	private void Start ()
	{
		for (int i=0; i<WeaponLists.Length; i++) {
			if (WeaponLists [i] != null) {
				WeaponLists [i].TargetTag = TargetTag;
				WeaponLists [i].ShowCrosshair = ShowCrosshair;
			}
		}
	}

	private void Update ()
	{
		
		for (int i=0; i<WeaponLists.Length; i++) {
			if (WeaponLists [i] != null) {
				WeaponLists [i].OnActive = false;
			}
		}
		if (CurrentWeapon < WeaponLists.Length && WeaponLists [CurrentWeapon] != null) {
			WeaponLists [CurrentWeapon].OnActive = true;
		}
	
	}
	
	public void LaunchWeapon (int index)
	{
		CurrentWeapon = index;
		if (CurrentWeapon < WeaponLists.Length && WeaponLists [index] != null) {
			WeaponLists [index].Shoot ();
		}
	}
	
	public void SwitchWeapon ()
	{
		CurrentWeapon += 1;
		if (CurrentWeapon >= WeaponLists.Length) {
			CurrentWeapon = 0;	
		}
	}
	
	public void LaunchWeapon ()
	{
		if (CurrentWeapon < WeaponLists.Length && WeaponLists [CurrentWeapon] != null) {
			WeaponLists [CurrentWeapon].Shoot ();
		}
	}
}
