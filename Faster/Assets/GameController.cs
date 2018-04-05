using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	
	public int nextRow = 1;
	public int nextBlack = 0;

	void Update () {
		
		if (Input.GetButtonDown("First") && nextBlack == 1){
			move ();
		}

		if (Input.GetButtonDown("Second") && nextBlack == 2){
			move ();
		}

		if (Input.GetButtonDown("Third") && nextBlack == 3){
			move ();
		}

		if (Input.GetButtonDown("Fourth") && nextBlack == 4){
			move ();
		}
	}

	void move () {
		transform.Translate (0, 4, 0);
		nextRow = nextRow + 1;
	}
}
