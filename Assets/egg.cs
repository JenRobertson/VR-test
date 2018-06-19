using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egg : MonoBehaviour {

	public int weight;
	public bool empty;

	// Use this for initialization
	void Start () {
		int randomNumber = Random.Range(0, 2);
		if (randomNumber == 0) {
			empty = true;
			weight = Random.Range(3, 6);
		}
		else {
			empty = false;
			weight = Random.Range(10, 16);
		}

		Debug.Log(weight);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
