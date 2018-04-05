using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour {

	public int blackBlock;
	public int rowNumber;

	public void block (int number) {
		blackBlock = number;
	}
}
