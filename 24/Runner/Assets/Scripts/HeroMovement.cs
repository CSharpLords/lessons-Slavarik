using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour {

	public Rigidbody rb;
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse0) && transform.position.y < 0.70f){
			rb.velocity = new Vector3(0, 10, 0);
		}
	}
}
