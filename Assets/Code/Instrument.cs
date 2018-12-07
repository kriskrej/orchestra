using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrument : MonoBehaviour {
	[SerializeField] Listener listener;
	float distanceToConductor;
	float MAX_DISTANCE = 20f;
	public float distance01;
	
	void Start () {
		listener = FindObjectOfType<Listener>();
	}

	void Update () {
		distanceToConductor = Vector3.Distance(transform.position, listener.transform.position);
		distance01 = Mathf.Clamp01 (distanceToConductor / MAX_DISTANCE);
	}
}
