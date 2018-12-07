using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrument : MonoBehaviour {
	Listener listener;
	AudioSource audioSource;
	float distanceToConductor;
	float MAX_DISTANCE = 25f;
	[Range(0f,1f)] public float distance01;
	
	void Start () {
		listener = FindObjectOfType<Listener>();
		audioSource = GetComponent<AudioSource> ();
	}

	void Update () {
		distanceToConductor = Vector3.Distance(transform.position, listener.transform.position);
		distance01 = 1-Mathf.Clamp01 (distanceToConductor / MAX_DISTANCE);
		audioSource.volume = distance01;
	}
}
