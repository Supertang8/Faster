using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour {

	public int blackBlock;
	public int rowNumber;

	private GameController gameController;

	void Start () {
		gameController = GameObject.FindWithTag ("MainCamera").GetComponent<GameController>();
	}

	void Update () {
		if (gameController.nextRow == rowNumber) {
			gameController.nextBlack = blackBlock;
		}
	}

	public void block (int number) {
		blackBlock = number;
	}
}
