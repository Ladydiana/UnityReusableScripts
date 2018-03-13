using UnityEngine;
using System.Collections;

/*
 * Translates in a given direction.
 */

public enum Direction {Left, Right, Up, Down, Forward, Backward};

public class BasicTranslate : MonoBehaviour
{
	public Direction d = Direction.Forward;

	// Update is called once per frame
	void Update () {
		switch (d) {
			case Direction.Backward:
				transform.localPosition += Vector3.back * Time.deltaTime;
				break;
			case Direction.Forward:
				transform.localPosition += Vector3.forward * Time.deltaTime;
				break;
			case Direction.Left:
				transform.localPosition += Vector3.left * Time.deltaTime;
				break;
			case Direction.Right:
				transform.localPosition += Vector3.right * Time.deltaTime;
				break;
			case Direction.Up:
				transform.localPosition += Vector3.up * Time.deltaTime;
				break;
			case Direction.Down:
				transform.localPosition += Vector3.down * Time.deltaTime;
				break;
			default:
				transform.localPosition += Vector3.forward * Time.deltaTime;
				break;
		}
	}
}

