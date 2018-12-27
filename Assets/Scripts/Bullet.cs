using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	Rigidbody rb;
	float speed = 0.2f;
	float highspeed = 0.5f;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody>();
	}
	// Update is called once per frame
	void Update () {
		Vector3 diff = (Camera.main.transform.position - transform.position);
		
		if(0< Input.touchCount){
			rb.velocity = diff * highspeed;
		}else{
			rb.velocity = diff * speed ;
		}
	}
}
