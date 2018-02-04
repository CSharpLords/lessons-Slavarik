using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTeleport : MonoBehaviour {
	float z = 0;
	float x = 0;
	float time = 0;
	public Transform enemy;
	void Start () {
		transform.position = Vector3.zero;
	}

	void Update () {
		float dist = Vector3.Distance(enemy.position, transform.position);
		time = time + Time.deltaTime;
		int seconds = (int)time;
		if (seconds == 1) {
			transform.position = new Vector3 (z, x, z);
			time = 0;
		}
		if (dist <= 3) {
			print ("Победа! Секретный предмет найден!!!");
		}
	}
}