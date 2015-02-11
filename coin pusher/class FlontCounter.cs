using UnityEngine;
using System.Collections;

public class FlontCounter : MonoBehaviour {

	public ChangeText point;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

				/*if (Input.GetKeyDown (KeyCode.Space)) {
			point-=1;
				}*/
		}

	void OnCollisionEnter(Collision col){

				Destroy (col.gameObject);
				point.point += 3;
		}

	/*void OnTriggerEnter(Collider collider){
		point += 5;
			
	}*/
}
