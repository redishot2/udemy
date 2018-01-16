using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 mouseTransform = new Vector3(0.5f, this.transform.position.y, this.transform.position.z);

 		float paddlePos = Input.mousePosition.x / Screen.width * 16;

 		mouseTransform.x = Mathf.Clamp(paddlePos, 0.5f, 15.5f);
		print(mouseTransform.x);

		this.transform.position = mouseTransform;
	}
}
