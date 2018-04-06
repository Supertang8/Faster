using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour {

	public int blackBlock;
	public int rowNumber;

	private GameController gameController;

	void Start () {
		gameController = GameObject.FindWithTag ("MainCamera").GetComponent<GameController>();
		rowNumber = gameController.nextRow + 4;
	}

	void Update () {
		if (gameController.nextRow == rowNumber) {
			gameController.nextBlack = blackBlock;
		}
		if (gameController.nextRow -1 == rowNumber) {
			Destroy (gameObject);
		}
	}

	public void block (int number) {
		blackBlock = number;
	}
}
