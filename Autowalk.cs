using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autowalk script
 * Walks in the direction the player is facing with a given speed.
 * Stop when facing the ground.
 */

public class Autowalk : MonoBehaviour {

	public GameObject ground;
	public float speed = 2.0f;
	private bool walking = false;


	// Update is called once per frame
	void Update () {
		if (walking) {
			transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
		}

		Ray ray = Camera.main.ViewportPointToRay (new Vector3 (.5f, .5f, 0));
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit)) {
			if (hit.collider.name.Contains (ground.name)) { //"Terrain"
				if (hit.distance <=5) {
					walking = false;
				}
			} else {
				walking = true;
			}
		} else {
			walking = true;
		}
	}
}