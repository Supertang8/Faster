using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer: MonoBehaviour {

	public Text timeText;
	public float timeCount;
	public float timeCount2;

	void Update () {

		float timeLocal = timeCount - Time.time;
		timeText.text = timeLocal.ToString("00");
		timeCount2 = timeLocal;
	}
}