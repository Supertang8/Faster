using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First5Rows : MonoBehaviour {

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
		if (gameController.transform.position.z == 26) {
			Destroy (gameObject);
		}
	}

	public void block (int number) {
		blackBlock = number;
	}
}
