/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour {
	
	[SerializeField] List<AudioSource> instruments;
	
	
	void Update () {
		foreach (var instrument in instruments)
			instrument.volume = CalculateVolume(listener.transform.position, instrument.transform.position);
	}

	float CalculateVolume(Vector3 instrument, Vector3 listener) {
		var distance = Vector3.Distance(instrument, listener);
		return Mathf.Clamp01(distance/)
	}
}
*/