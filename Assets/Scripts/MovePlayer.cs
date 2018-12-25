using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
	[SerializeField]
	Camera camera;

	// Use this for initialization
	void Start () {
		this.transform.position = camera.transform.position;
	}
	// Update is called once per frame
	void Update () {
		this.transform.position = camera.transform.position;
	}
}
