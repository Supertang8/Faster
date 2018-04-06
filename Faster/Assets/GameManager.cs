using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	
	private float timeLocal;
	public GameObject timer;

	void Start(){

		timer = GameObject.FindWithTag("Timer");
	}

	void Update(){
		timeLocal = timer.GetComponent<Timer> ().timeCount2;
		if (timeLocal < 0){
			Application.Quit ();
		}
	}
}
