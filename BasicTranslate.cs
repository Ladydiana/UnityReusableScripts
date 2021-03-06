using UnityEngine;
using System.Collections;

/*
 * Translates in a given direction with a given speed.
 */

// define the possible states through an enumeration
public enum Direction {Left, Right, Up, Down, Forward, Backward};

public class BasicTranslate : MonoBehaviour
{
	public Direction d = Direction.Forward;
	public float speed = 1.0f;

	// Update is called once per frame
	void Update () {
		switch (d) {
			case Direction.Backward:
				transform.localPosition += Vector3.back * Time.deltaTime * speed;
				break;
			case Direction.Forward:
				transform.localPosition += Vector3.forward * Time.deltaTime * speed;
				break;
			case Direction.Left:
				transform.localPosition += Vector3.left * Time.deltaTime * speed;
				break;
			case Direction.Right:
				transform.localPosition += Vector3.right * Time.deltaTime * speed;
				break;
			case Direction.Up:
				transform.localPosition += Vector3.up * Time.deltaTime * speed;
				break;
			case Direction.Down:
				transform.localPosition += Vector3.down * Time.deltaTime * speed;
				break;
			default:
				transform.localPosition += Vector3.forward * Time.deltaTime * speed;
				break;
		}
	}
}

