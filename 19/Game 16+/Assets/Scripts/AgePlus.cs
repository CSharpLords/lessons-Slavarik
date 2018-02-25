using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgePlus : MonoBehaviour {
	int plus = 1;
	public Text ageField;
	void Start () {
		Button plus = GetComponent<Button> ();
		plus.onClick.AddListener (Increase);
		ageField.text = "18";
	}
	

	void Increase () {
		AgeMinus.age = plus + AgeMinus.age;
		ageField.text = AgeMinus.age.ToString();
	}
}