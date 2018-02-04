using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public Transform enemy;

	void Start () {
		
	}
	

	void Update () {
		print (enemy.position.x);
		print (enemy.position.y);
		print (enemy.position.z);
	}
}
