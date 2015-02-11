using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public bool stopCoin=false;

	public GameObject myPrefab;
	public ChangeText coin;
	public GameState gameState;

	public float angle=0;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		angle += 0.05f;
		transform.position = new Vector3 (Mathf.Sin (angle * 1.8f), 4, 0);
		if (angle >= 360) {angle = 0;}

		//if (Time.time % 20 == 0) {
						//Vector3 offs = new Vector3 (Mathf.Sin (Time.time * 2) * 3, 0, 0);
						//Instantiate (myPrefab, transform.position + offs, transform.rotation);
		//};

		if (!stopCoin && Input.GetKeyDown (KeyCode.Space)) {
								Instantiate (myPrefab, transform.position, transform.rotation);
				                coin.point-=1;
				                gameState.timer=0;
				}
	}
}

