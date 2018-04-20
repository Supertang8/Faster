using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	
	public int nextRow = 1;
	public int nextBlack = 0;
	public GameObject[] rows;
	public GameObject spawnPoint;
	public Text scoreCount;
	public float scoreText;
	public bool alive = true;
	public float streakLossTime;
	public float ThreeStreakBonus = 3;
	public int timePenalty = 5;
	public GameObject bonus;

	private Timer timer;
	private float streaktime = 0;
	private int streak= 0;

	void Start()
	{
	
		timer = GameObject.FindWithTag ("Timer").GetComponent<Timer> ();
		scoreText = 0;
	}


	void Update () {

		streaktime = streaktime + Time.deltaTime;

		if (streaktime >= streakLossTime) 
		{
			streak = 0;
			Debug.Log ("Streak = 0 - Streak lost");
			bonus.SetActive (false);
		}

		if (alive) 
		{
			if (Input.GetButtonDown ("First") && nextBlack == 1) {
				move ();
				scoreInc ();
			} else if (Input.GetButtonDown ("Second") && nextBlack == 2) {
				move ();
				scoreInc ();
			} else if (Input.GetButtonDown ("Third") && nextBlack == 3) {
				move ();
				scoreInc ();
			} else if (Input.GetButtonDown ("Fourth") && nextBlack == 4) {
				move ();
				scoreInc ();
			} else if (Input.GetButtonDown ("First") && nextBlack != 1) {
				timeDec ();
			} else if (Input.GetButtonDown ("Second") && nextBlack != 2) {
				timeDec ();
			} else if (Input.GetButtonDown ("Third") && nextBlack != 3) {
				timeDec ();
			} else if (Input.GetButtonDown ("Fourth") && nextBlack != 4) {
				timeDec ();
			}
		}
	}

	void move () {

		Instantiate (rows[Random.Range(0, 4)], spawnPoint.transform.position, Quaternion.identity);

		transform.Translate (0, 4, 0);
		nextRow = nextRow + 1;

	}

	void scoreInc(){

		scoreText = scoreText + 3;
		streaktime = 0.0f;
		streak = streak + 1;
		Debug.Log ("streak = " + streak);

		if (streak == 3) {
			timer.timeCount = timer.timeCount + ThreeStreakBonus;
			Debug.Log ("+3sec");
			bonus.SetActive (true);
		} else {
			bonus.SetActive (false);
		}

	}

	void timeDec(){
	
		bonus.SetActive (false);
		timer.timeCount = timer.timeCount - timePenalty;
		streak = 0;
		Debug.Log ("Streak = 0 - Streak lost");

	}
}
