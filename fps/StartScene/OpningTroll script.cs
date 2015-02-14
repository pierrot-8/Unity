using UnityEngine;
using System.Collections;

public class OpTroll : MonoBehaviour {
	public int a = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	private void Move(){
		Vector3 pos = transform.position;
		transform.Translate (new Vector3 (0, 0, 0.1f));
		if (pos.x <= -15) {
			a *= -1;
				}
		}
}
