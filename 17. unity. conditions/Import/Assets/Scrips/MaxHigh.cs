using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxHigh : MonoBehaviour {
	float high = 0;
	float min = 0;

	void Update () {
		if (transform.position.y > high) {
			print ("Максимальная высота:" + high);
			high = transform.position.y;
		}
		if (transform.position.y < min) {
			print ("Минимальная высота:" + min);
			min = transform.position.y;
		}
	}
}
