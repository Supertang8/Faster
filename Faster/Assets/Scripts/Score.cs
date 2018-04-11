using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreText;
	public float scoreCount;
	public GameObject mainCamera;

	void Start () {

		mainCamera = GameObject.FindWithTag("MainCamera");
	}

	void Update(){

		scoreCount =mainCamera.GetComponent<GameController> ().scoreText;
		scoreText.text = scoreCount.ToString("0");
	}
}
