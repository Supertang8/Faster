using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	
	public int nextRow = 1;
	public int nextBlack = 0;

	void Update () {
		
		if (Input.GetButtonDown("First") && nextBlack == 1){
			transform.Translate (0, 4, 0);
			nextRow = nextRow + 1;
		}

		if (Input.GetButtonDown("Second") && nextBlack == 2){
			transform.Translate (0, 4, 0);
			nextRow = nextRow + 1;
		}

		if (Input.GetButtonDown("Third") && nextBlack == 3){
			transform.Translate (0, 4, 0);
			nextRow = nextRow + 1;
		}

		if (Input.GetButtonDown("Fourth") && nextBlack == 4){
			transform.Translate (0, 4, 0);
			nextRow = nextRow + 1;

		}
	}
}
