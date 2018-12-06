using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrument : MonoBehaviour {
	[SerializeField] Listener listener;
	float distanceToConductor;
	
	void Start () {
		listener = FindObjectOfType<Listener>();
	}
	
	// Update is called once per frame
	void Update () {
		//distanceToConductor = 
	}
}
