using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
	public Transform hero; 

	void Start () {
		
	}
	

	void Update () {
		transform.position = new Vector3 (hero.position.x, transform.position.y, transform.position.z );
	}
}
