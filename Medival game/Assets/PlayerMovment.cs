﻿using UnityEngine;
using System.Collections;

public class PlayerMovment : MonoBehaviour {

	void Start () {

	}




	void Update(){

		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 20.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
	}
}