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

		timer = GameObject.FindWithTag("Timer");
		gameController = GameObject.FindWithTag ("MainCamera").GetComponent<GameController> ();

	}

	void Update(){
		timeLocal = timer.GetComponent<Timer> ().timeCount2;
		if (timeLocal < 0){
			StartCoroutine("Quit");
		}
	}

	IEnumerator Quit () {
		gameOverText.SetActive (true);
		timer.SetActive (false);
		yield return new WaitForSeconds (2);
		SceneManager.LoadScene (0);
	}

}
