using UnityEngine;
using System.Collections;

public class ChangeText : MonoBehaviour {

	public int point;
	private string displayText; 

	public FlontCounter count;
	public GameState time;

	// Use this for initialization
	public void Start () {
		point = 30;
	}
	
	// Update is called once per frame
	void Update () {

		//string displayText = "POINT"+(point);
		//guiText.text=displayText;

		if (time.timeup && point <= 0) {
			displayText = "GAMEOVER";
			guiText.text = displayText;
		}
		else if (point >= 40) {
			displayText = "GAMECLEAR";
			guiText.text = displayText;
		}
		else {
			displayText = "POINT"+(point);
			guiText.text = displayText;
		}

	}
  }

