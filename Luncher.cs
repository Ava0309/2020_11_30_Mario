using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luncher : MonoBehaviour {

	public GameObject ballPrefab;

	private void Update() {
		if(Input.GetMouseButtonDown(1)){
			Instantiate(ballPrefab,transform.position,transform.rotation);
		}
	}
}
