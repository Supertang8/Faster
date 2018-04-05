using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	public int number;
	public bool IsBlack;

	void Start () {
		if (IsBlack == true) {
		
			GetComponentInParent<Row>().block(number);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
