using UnityEngine;
using System.Collections;

/*
 * Teleports a game object to a given position.
 */

public class TeleportToPosition : MonoBehaviour
{
	public GameObject objectToTeleport;
	public GameObject newLocation;
	
	// Update is called once per frame
	void Update ()
	{
		if (objectToTeleport != null && newLocation!=null) {
			objectToTeleport.transform.position = newLocation.transform.position;
		}
	}
}

