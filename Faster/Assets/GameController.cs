using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	private int nextRow;


	void Update () {
		if (Input.GetButtonDown("First")){
			transform.Translate (0, 2, 0);
		}
		if (Input.GetButtonDown("Second")){
			transform.Translate (0, 2, 0);
		}
		if (Input.GetButtonDown("Third")){
			transform.Translate (0, 2, 0);
		}
		if (Input.GetButtonDown("Fourth")){
			transform.Translate (0, 2, 0);
		}
	}
}
