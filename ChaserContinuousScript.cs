using UnityEngine;
using System.Collections;


/*
 * Follows a given target.
 */

 
public class ChaserContinuousScript : MonoBehaviour {
	
	public float chaseSpeed = 20.0f;
	public float minDistanceToTarget = 1.0f;
	public GameObject target;

	// Use this for initialization
	void Start () {
		// if no target specified, assume the player
		if (target == null) {
			if (GameObject.FindWithTag ("Player")!=null) {
				target = GameObject.FindWithTag ("Player");
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (target == null)
			return;

		// face the target
		transform.LookAt(target.transform);

		//get the distance between the chaser and the target
		float distance = Vector3.Distance(transform.position, target.transform.position);

		//as long as the chaser is farther away than the minimum distance, move towards it at chase speed.
		if(distance > minDist)	{
			transform.position += transform.forward * chaseSpeed * Time.deltaTime;
		}			
	}

	// Set the target of the chaser
	public void SetTarget(GameObject newTarget) {
		target = newTarget;
	}

}