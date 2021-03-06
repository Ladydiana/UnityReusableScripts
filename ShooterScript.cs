using UnityEngine;
using System.Collections;

/*
 * Shoot Projectiles Script.
 * To be attached to the Camera.
 */

public class ShooterScript : MonoBehaviour
{
	// Reference to projectile prefab to shoot
	public GameObject projectile;
	public float power = 10.0f;

	// Reference to AudioClip to play on projectile launch
	public AudioClip shootSFX;
	
	// Update is called once per frame
	void Update ()	{
		
		// if fire button is pressed
		// Fire1 is mapped to Control. To be changed if another button is in use
		if (Input.GetButtonDown ("Fire1")) {

			// if projectile prefab is specified
			if (projectile) {

				// Instantiante projectile at the camera + 1 meter forward with camera rotation
				GameObject newProjectile = Instantiate(projectile, transform.position + transform.forward, transform.rotation) as GameObject;

				// if the projectile does not have a rigidbody component, add one
				// need the rigidbody for collision detection
				if (!newProjectile.GetComponent<Rigidbody>()) {
					newProjectile.AddComponent<Rigidbody>();
				}
				// Apply force to the newProjectile's Rigidbody component if it has one
				newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * power, ForceMode.VelocityChange);

				// play gunfire sound effect if set
				if (shootSFX) {
					
					// if the projectile has an AudioSource component play the sound clip through the AudioSource component on the gameobject.
					// note: The audio will travel with the gameobject.
					if (newProjectile.GetComponent<AudioSource> ()) { 
						newProjectile.GetComponent<AudioSource> ().PlayOneShot (shootSFX);
					}
					// else dynamically create a new gameObject with an AudioSource
					// this automatically destroys itself once the audio is done
					else {
						AudioSource.PlayClipAtPoint (shootSFX, newProjectile.transform.position);
					}
				}
			}
		}
	
	}
}

