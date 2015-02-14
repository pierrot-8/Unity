using UnityEngine;
using System.Collections;

public class SEControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
						audio.Play ();
				}
	
	}
}
