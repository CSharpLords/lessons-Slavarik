using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraficLight : MonoBehaviour {
	Renderer rend;
	void Start () {
		rend = GetComponent<Renderer>();
	}

	void Update () {
		if (Input.GetKey(KeyCode.DownArrow)){
			rend.material.color = Color.red;
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			rend.material.color = Color.yellow;
		}
		if (Input.GetKey(KeyCode.UpArrow)){
			rend.material.color = Color.green;
		}
	}
}
