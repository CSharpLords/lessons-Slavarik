using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSuperMegaTeleport : MonoBehaviour {
	public Transform enemy;
	void Start () {		
	}
	void Update () {
		float dist = Vector3.Distance(enemy.position, transform.position);
		if (dist <= 3) {
			print ("U WIN");
		}
	}
}
