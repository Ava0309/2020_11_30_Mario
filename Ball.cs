using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private void Start() {
		this.GetComponent<Rigidbody>()
		.velocity=new Vector3(-10f,9f,0f);
	}

	private void OnBecameInvisible() {
		Destroy(this.gameObject);
	}
}
