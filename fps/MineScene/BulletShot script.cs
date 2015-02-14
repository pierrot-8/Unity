using UnityEngine;
using System.Collections;

public class BulletShot : MonoBehaviour {
	public GameObject bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ShotBullet ();
	}

	private void ShotBullet(){
				if (Input.GetKeyDown ("space")) {
						Instantiate (bullet, transform.position, Quaternion.identity);
				}
		}
}
