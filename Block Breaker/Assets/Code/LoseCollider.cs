using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	public SceneManager levelManager;

	void OnTriggerEnter2D(Collider2D trigger) {
		print ("trigger");
		levelManager.LoadLevel("WinScreen");
	}

	void OnCollisionEnter2D(Collision2D collision2D) {
		print ("collision");
	}
}
