using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	//public float kakudo = 0;
	//public float ran =10.0f;
	public Vector3 left1 = new Vector3(0,-1.0f,0);
	public Vector3 right1 = new Vector3(0, 1.0f,0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		MoveCamera ();

	}

	private void Move(){
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate(0, 0, 0.4f);
		}
		if (Input.GetKey (KeyCode.X)) {
			transform.Translate(0, 0, -0.4f);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate(-0.4f, 0, 0);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate(0.4f, 0, 0);
		}
	}
	private void MoveCamera(){
				if (Input.GetKey (KeyCode.Q)) {
						transform.Rotate(left1);
				}
				if (Input.GetKey (KeyCode.E)) {
			             transform.Rotate(right1);
				}
		}
	//transform.Rotate (0, (Input.GetAxis ("Horizontal") * 1), 0);
}
