using UnityEngine;
using System.Collections;

/*
 * Basic Object Animations.
 * States: 
 * 	- Rotate with a give speed
 * 		x Rotate around the X axis
 * 		x Rotate around the Y axis
 * 	- Translate with a given speed
 * 		x Translate up and down
 * 		x Translate left and right
 */


// define the possible states through two enumeration
public enum motionRotations {None, SpinRight, SpinUp};
public enum motionTranslations {None, Horizontal, Vertical};

public class BasicObjectMover : MonoBehaviour
{
	public motionRotations rotation = motionRotations.None;
	public motionTranslations translate = motionTranslations.None;
	public float translateSpeed = 1.0f;
	public float rotateSpeed = 1.0f;

	// Update is called once per frame
	void Update ()
	{
		switch (rotation) {
			case motionRotations.SpinRight: 
				transform.Rotate (Vector3.right * Time.deltaTime * rotateSpeed);
				break;
			case motionRotations.SpinUp:
				transform.Rotate (Vector3.up * Time.deltaTime * rotateSpeed);
				break;
			case motionRotations.None:
				break;
			default:
				break;
		}

		switch (translate) {
			case motionTranslations.Horizontal:
				// move left and right over time
				transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * translateSpeed);
				break;	
			case motionTranslations.Vertical:
				// move up and down over time
				transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
				break;
			case motionTranslations.None:
				break;
			default:
				break;
		}
	}
}

