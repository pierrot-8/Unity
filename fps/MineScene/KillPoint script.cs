using UnityEngine;
using System.Collections;

public class KillPoint : MonoBehaviour {

	public int killPoint = 0;

	// Use this for initialization
	void Start () {
		string text = "Kill   " +killPoint;
	
	}
	
	// Update is called once per frame
	void Update () {
		string displayText = "kill"+killPoint;
		guiText.text = displayText;
	}
}
