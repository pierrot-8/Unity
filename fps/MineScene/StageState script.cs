using UnityEngine;
using System.Collections;

public class StageState : MonoBehaviour {

	public StageTime time;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (time.Stagetime <= 0) {
						Application.LoadLevel ("Goal");
				}
	}
}
