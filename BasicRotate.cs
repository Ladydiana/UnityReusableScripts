using UnityEngine;
using System.Collections;

/* 
 * Rotates in a given direction with a given speed.
 */ 


// define the possible states through an enumeration
public enum Axis {rotateOnX, rotateOnY};

public class BasicRotate : MonoBehaviour
{
	public Axis axis = Axis.rotateOnX;
	public float speed = 1.0f;

	void Update () {
		switch (axis) {
		case Axis.rotateOnX:
			transform.Rotate (Vector3.right * Time.deltaTime * speed);
			break;
		case Axis.rotateOnY:
			transform.Rotate (Vector3.up * Time.deltaTime * speed);
			break;
		default:
			transform.Rotate (Vector3.right * Time.deltaTime * speed);
			break;
		}
	}
}

