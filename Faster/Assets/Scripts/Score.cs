using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreText;
	public float scoreCount;
	public GameObject camera;

	void Start () {

		camera = GameObject.FindWithTag("MainCamera");
	}

	void Update(){

		scoreCount = camera.GetComponent<GameController> ().scoreText;
		scoreText.text = scoreCount.ToString("0");
	}
}
