using UnityEngine;
using System.Collections;

public class ColorYellow : MonoBehaviour {

	public RaycastHit hit;
	public bool flgred = false;
	public GameObject yellowrect;
	public GameObject cube;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			Vector3 pos = Input.mousePosition;
			Ray ray = Camera.main.ScreenPointToRay (pos);
			if (Physics.Raycast (ray, out hit)) {
				yellowrect = hit.collider.gameObject;
				if (yellowrect.tag == "yellowrect") {
					cube = GameObject.Find ("Cube");
					cube.renderer.material.color = Color.yellow;
				}
			}
		}
		
	}
}
