using UnityEngine;
using System.Collections;

public class BulletMove0 : MonoBehaviour {
	public float bulletSpeed=1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, bulletSpeed);
	}
	
}
