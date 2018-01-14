using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test : MonoBehaviour 
{
	float time = 0;
	// Use this for initialization
	void Start () {
		print ("Hello world");
	}
	
	// Update is called once per frame
	void Update () {
		print ("update");
		print ("Координаты:" + "x = " + transform.position.x + ", y = " + transform.position.y + ", z = " + transform.position.z);
		time = time + Time.deltaTime;
		int seconds = (int) time;
		print ("Количество секунд: " + seconds); 
	}
}
