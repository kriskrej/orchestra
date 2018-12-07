using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEverythingAtFullMinute : MonoBehaviour {
	

	IEnumerator Start () {
		var sources = FindObjectsOfType<AudioSource> ();
		while(System.DateTime.Now.Second > 1){
			Debug.Log (System.DateTime.Now.Second);
			yield return null;
		}
		foreach (var src in sources)
			src.Play ();
	}

}
