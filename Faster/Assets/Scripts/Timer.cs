using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer: MonoBehaviour {

	public Text timeText;
	public float timeCount;

	void Update () {

		timeCount = timeCount - Time.deltaTime;
		timeText.text = timeCount.ToString("00");
	}
}