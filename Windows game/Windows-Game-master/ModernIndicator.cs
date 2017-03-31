/// <summary>
/// Modern indicator. this script will display an F16 HUD
/// </summary>
using UnityEngine;
using System.Collections;

public class ModernIndicator : Indicator
{

	public Texture2D HlineTexture;
	public Texture2D HlineStepTexture;
	
	void OnGUI ()
	{

		if (Show) {
			GUI.color = Color.green;
			switch (Mode) {
			case NavMode.Third:

				break;
			case NavMode.Cockpit:
				if (Crosshair_in)
					GUI.DrawTexture (new Rect ((Screen.width / 2 - Crosshair_in.width / 2) + CrosshairOffset.x, (Screen.height / 2 - Crosshair_in.height / 2) + CrosshairOffset.y, Crosshair_in.width, Crosshair_in.height), Crosshair_in);	
				DrawNavEnemy ();
				
				Matrix4x4 matrixBackup = GUI.matrix;
				GUIUtility.RotateAroundPivot (this.gameObject.transform.rotation.eulerAngles.z, new Vector2 (Screen.width / 2, Screen.height / 2));
				
				if (HlineTexture)
					GUI.DrawTexture (new Rect ((Screen.width / 2 - HlineTexture.width / 2), (Screen.height / 2 - HlineTexture.height / 2), HlineTexture.width, HlineTexture.height), HlineTexture);
				
				if (HlineStepTexture)
					GUI.DrawTextureWithTexCoords (new Rect ((Screen.width / 2 - HlineStepTexture.width / 2), (Screen.height / 2 - 200), HlineStepTexture.width, 400), HlineStepTexture, new Rect (1, this.gameObject.transform.position.y * 0.01f, 1, 5));
				
				
				GUI.matrix = matrixBackup;
				GUI.skin.label.alignment = TextAnchor.UpperLeft;
				GUI.Label (new Rect (Screen.width / 2 - 170, Screen.height / 2 - 150, 400, 30), flight.gameObject.GetComponent<Rigidbody>().velocity.magnitude.ToString ());
				break;
			case NavMode.None:
				
				break;
			}
		}
	}
}
