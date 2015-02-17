using UnityEngine;
using System.Collections;

public class CubeRotation : MonoBehaviour {

	public Vector3 cubeRote;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		cubeRote = new Vector3 (0.1f, 0.1f, 0.1f);
		transform.Rotate (cubeRote);
	
	}
}
