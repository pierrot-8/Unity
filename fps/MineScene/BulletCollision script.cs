using UnityEngine;
using System.Collections;

public class BulletCollision : MonoBehaviour {

	public KillPoint point;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision col){
				if (col.gameObject.tag == "Bullet") {
						Destroy (gameObject);
			point.killPoint++;
				}
		}

}
