using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {

	Vector3 origin;
	// Use this for initialization
	void Start () {
		origin = rigidbody.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 offs = new Vector3 (0, 0, Mathf.Sin (Time.time));
		rigidbody.MovePosition (origin + offs);
	}
}
