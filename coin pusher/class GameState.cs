using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

	public ChangeText score;
	public Spawner spawn;
	
	private float waitTime=15;
	public  float timer = 0;
	public  bool timeup=false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		if (spawn.stopCoin && timer > waitTime) {
			timeup=true;
		}

		if (score.point <= 0 || score.point >= 40) {
						spawn.stopCoin = true;
				} else {
						spawn.stopCoin = false;
				}

	}
}
