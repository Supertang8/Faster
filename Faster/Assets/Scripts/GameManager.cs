using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	
	private float timeLocal;
	private GameObject timer;
	private GameController gameController;

	public GameObject gameOverText;

	void Start(){

		gameController = GameObject.FindWithTag ("MainCamera").GetComponent<GameController> ();
		timer = GameObject.FindWithTag("Timer");

	}

	void Update(){
		timeLocal = timer.GetComponent<Timer> ().timeCount;
		if (timeLocal < 0){
			StartCoroutine("Quit");
		}
	}

	IEnumerator Quit () {
		gameController.alive = false;
		gameOverText.SetActive (true);
		timer.SetActive (false);
		yield return new WaitForSeconds (2);
		SceneManager.LoadScene (0);
	}

}
