using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgeMinus : MonoBehaviour {
	int minus = 1;
	public Text ageField;
	public static int age = 18;
	void Start () {
		Button plus = GetComponent<Button> ();
		plus.onClick.AddListener (Increase);
		ageField.text = "18";
	}


	void Increase () {
		age = age - minus;
		ageField.text = age.ToString();
	}
}