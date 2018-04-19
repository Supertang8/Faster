using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	
	public int nextRow = 1;
	public int nextBlack = 0;
	public GameObject[] rows;
	public GameObject spawnPoint;
	public Text scoreCount;
	public float scoreText;
	public bool alive = true;

	private Timer timer;

	void Start(){
	
		timer = GameObject.FindWithTag ("Timer").GetComponent<Timer> ();
		scoreText = 0;
	}


	void Update () {
		if (alive) 
		{
			if (Input.GetButtonDown ("First") && nextBlack == 1) {
				move ();
				scoreInc ();
			} else if (Input.GetButtonDown ("Second") && nextBlack == 2) {
				move ();
				scoreInc ();
			} else if (Input.GetButtonDown ("Third") && nextBlack == 3) {
				move ();
				scoreInc ();
			} else if (Input.GetButtonDown ("Fourth") && nextBlack == 4) {
				move ();
				scoreInc ();
			} else if (Input.GetButtonDown ("First") && nextBlack != 1) {
				timeDec ();
			} else if (Input.GetButtonDown ("Second") && nextBlack != 2) {
				timeDec ();
			} else if (Input.GetButtonDown ("Third") && nextBlack != 3) {
				timeDec ();
			} else if (Input.GetButtonDown ("Fourth") && nextBlack != 4) {
				timeDec ();
			}
		}
	}

	void move () {

		Instantiate (rows[Random.Range(0, 4)], spawnPoint.transform.position, Quaternion.identity);

		transform.Translate (0, 4, 0);
		nextRow = nextRow + 1;

	}

	void scoreInc(){

		scoreText = scoreText + 3;

	}

	void timeDec(){
	
		timer.timeCount = timer.timeCount - 5;

	}
}
