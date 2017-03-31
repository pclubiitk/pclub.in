/// <summary>
/// Camera sway. this script will move/sway an object along with it parent.
/// </summary>
using UnityEngine;
using System.Collections;

public class CameraSway : MonoBehaviour
{
	public float SwaySensitivity = 10;
	
	private float parentMagnitude;
	private Vector3 positionTemp;
	private Quaternion rotationTemp;
	private Vector3 parentPositionMagnitude;
	private Vector3 parentPositionTemp;
	private Vector3 parentRotationMagnitude;
	private Quaternion parentRotationTemp;

	
	void Awake ()
	{
		// save start position and rotation
		positionTemp = this.transform.localPosition;
		rotationTemp = this.transform.localRotation;
	}

	void FixedUpdate ()
	{
		float swayMagX = Mathf.Cos(Time.time * parentMagnitude) * Time.fixedDeltaTime;
		float swayMagZ = Mathf.Sin(Time.time * parentMagnitude) * Time.fixedDeltaTime;
		
		if (transform.parent) {
			// find a difference between old and new position. then using to moving
			parentPositionMagnitude = Vector3.ClampMagnitude (transform.parent.position - parentPositionTemp, 1);
			parentRotationMagnitude = transform.parent.localRotation.eulerAngles - parentRotationTemp.eulerAngles;
			
			// get magnitude from the parent.
			if (transform.parent.GetComponent<Rigidbody>())
				parentMagnitude = transform.parent.GetComponent<Rigidbody>().velocity.magnitude * 0.05f;
	
		
			this.transform.localPosition = positionTemp + (SwaySensitivity * new Vector3(swayMagX,parentPositionMagnitude.y,swayMagZ)) * Time.fixedDeltaTime;
			this.transform.localRotation = Quaternion.Lerp (this.transform.localRotation, Quaternion.Euler ((rotationTemp.eulerAngles.x + parentRotationMagnitude.x + swayMagX), (rotationTemp.eulerAngles.y + parentRotationMagnitude.y), (rotationTemp.eulerAngles.z + parentRotationMagnitude.z + swayMagZ)), Time.fixedDeltaTime * SwaySensitivity);

			parentPositionTemp = transform.parent.position;
			parentRotationTemp = transform.parent.localRotation;
		}
	}

}
