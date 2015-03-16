using UnityEngine;
using System.Collections;

public class MoveControl : MonoBehaviour {

	public bool jump = false;

	public float force = 20.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			rigidbody2D.AddForce (transform.up * force,ForceMode2D.Impulse);
		}


	}
}
