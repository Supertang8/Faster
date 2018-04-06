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

	void Start(){
	
		scoreText = 0;

	}


	void Update () {
		
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
			scoreDec ();
		} else if (Input.GetButtonDown ("Second") && nextBlack != 2) {
			scoreDec ();
		} else if (Input.GetButtonDown ("Third") && nextBlack != 3) {
			scoreDec ();
		} else if (Input.GetButtonDown ("Fourth") && nextBlack != 4) {
			scoreDec ();
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

	void scoreDec(){
	
		scoreText = scoreText - 10;

	}
}
