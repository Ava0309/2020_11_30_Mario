using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float jumpSpeed = 5f;
    public bool isLanding;

    void Update()
    {
        if (isLanding == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
				this.isLanding=false;
                this.gameObject.GetComponent<Rigidbody>()
                .velocity = Vector3.up * jumpSpeed;
            }
        }
    }

	private void OnCollisionEnter(Collision other) {
		if(other.gameObject.tag=="Floor"){
			this.isLanding=true;
		}
		
	}
}
