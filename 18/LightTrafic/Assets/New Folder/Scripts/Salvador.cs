using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salvador : MonoBehaviour {
	float time = 0;
	Renderer rend;
	void Start () {
		rend = GetComponent<Renderer>();
	}
	void Update () {
		time = time + Time.deltaTime;
		int seconds = (int)time; 
		if (seconds == 1) {
			rend.material.color = Color.red;
		}
		if (seconds == 2) {
			rend.material.color = Color.yellow;
		}
		if (seconds == 3) {
			rend.material.color = Color.green;
			time = 0;
		}
	}
}