using UnityEngine;
using System.Collections;

public static class MouseLock
{
	private static bool mouseLocked;

	
	public static bool MouseLocked {
		get {
			return mouseLocked;
		}
		set {
			mouseLocked = value;
			
			#if UNITY_4_6
				Screen.lockCursor = mouseLocked;
			#else
				Cursor.visible = !value;
				if (Cursor.visible) {	
					Cursor.lockState = CursorLockMode.None;
				} else {
					Cursor.lockState = CursorLockMode.Locked;
			
				}
			#endif
		}
	}
	

}

