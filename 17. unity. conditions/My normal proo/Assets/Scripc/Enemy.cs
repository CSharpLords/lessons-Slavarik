using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public Transform enemy;

	void Start () {		
	}


	void Update () {
		float dist = Vector3.Distance(enemy.position, transform.position);
		print (dist);
	}
}
