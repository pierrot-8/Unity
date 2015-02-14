using UnityEngine;
using System.Collections;

public class StageTime : MonoBehaviour {

	public int Stagetime = 1000;

	// Use this for initialization
	void Start () {
		string text = "Time" + Stagetime;
	}
	
	// Update is called once per frame
	void Update () {
		Stagetime--;
		string displayText = "Time"+Stagetime;
		guiText.text = displayText;

		if (Stagetime <= 0) {
						Stagetime = 0;
				}
	
	}
}
