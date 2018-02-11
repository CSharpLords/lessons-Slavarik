using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTeleport : MonoBehaviour {
	float time = 0;
	public Transform enemy;
	void Start () {
	}

	void Update () {
		float dist = Vector3.Distance(enemy.position, transform.position);
		time = time + Time.deltaTime;
		int seconds = (int)time;
		if (dist <= 3) {
			enemy.position = new Vector3 (1, 2, 1);
		}
	}
}