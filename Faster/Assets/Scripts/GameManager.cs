using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	
	private float timeLocal;
	private GameObject timer;

	public GameObject gameOverText;

	void Start(){

		timer = GameObject.FindWithTag("Timer");

	}

	void Update(){
		timeLocal = timer.GetComponent<Timer> ().timeCount;
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
