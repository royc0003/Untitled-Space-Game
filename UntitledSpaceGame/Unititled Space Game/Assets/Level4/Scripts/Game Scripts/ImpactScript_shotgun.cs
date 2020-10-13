using UnityEngine;
using System.Collections;

// ----- Low Poly FPS Pack Free Version -----
public class ImpactScript_shotgun : MonoBehaviour {

	[Header("Impact Despawn Timer")]
	//How long before the impact is destroyed
	public float despawnTimer = 10.0f;

	[Header("Audio")]
	public AudioClip[] impactSounds;
	public AudioClip[] afterSounds;
		public AudioSource audioSource;

	private IEnumerator Start () {
		// Start the despawn timer
		StartCoroutine (DespawnTimer ());

		//Get a random impact sound from the array
		audioSource.clip = impactSounds
			[Random.Range(0, impactSounds.Length)];
		//Play the random impact sound
		audioSource.Play();
		
		yield return new WaitForSeconds(audioSource.clip.length);
		audioSource.clip = afterSounds
			[Random.Range(0, afterSounds.Length)];
		audioSource.Play();
	}
	
	private IEnumerator DespawnTimer() {
		//Wait for set amount of time
		yield return new WaitForSeconds (despawnTimer);
		//Destroy the impact gameobject
		Destroy (gameObject);
	}
}