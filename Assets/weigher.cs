using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class weigher : MonoBehaviour {
	//todo
	//add dial animation at correct time
	//add pot animation at right time
	//add removing egg pot animation at right time + make it
	//make it animate back to zero properly?

	//make eggs bigger based on their weight? hmm
	//add proper collider to the weigher

	public Transform dial;
	public Transform pot;

	private float zAngleTarget;
	private float secondsToLerp;
	float t;

	void Start () {
		t = 0;
		zAngleTarget = 0;
		secondsToLerp = 1;
	}
	
	void Update () {
		t += Time.deltaTime / secondsToLerp;
		dial.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(0,zAngleTarget, t));
	}

	void OnTriggerEnter (Collider collider) {
		if (collider.tag == "egg") {
			rotateDial(collider.gameObject.GetComponent<egg>().weight);
		}
		Debug.Log("go!");
	}
 
 	void OnTriggerExit (Collider collider) {
		if (collider.tag == "egg") {
			rotateDial(0);
		}
	}

	void rotateDial(int degrees){
		t = 0;
		zAngleTarget = -degrees * 19;
	}
}