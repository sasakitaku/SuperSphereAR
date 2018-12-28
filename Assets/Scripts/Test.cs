using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	[SerializeField]
	GameObject createobj;
	[SerializeField]
	Camera camera;
	int i;
	int itemCount = 85;
	Vector3 pos;
	int radius = 4;
	float angle1;
	float angle2;

	// Use this for initialization
	void Start () {
		Vector3 camera_pos = camera.transform.position;
		for (i = 0; i < itemCount; ++i)
		{
			angle1 = Random.Range(0,360);
			angle2 = Random.Range(0,360);
			pos = new Vector3(radius*Mathf.Sin(angle2*Mathf.Deg2Rad)*Mathf.Cos(angle1*Mathf.Deg2Rad),
		    radius*Mathf.Cos(angle2*Mathf.Deg2Rad),radius*Mathf.Sin(angle2*Mathf.Deg2Rad)*Mathf.Sin(angle1*Mathf.Deg2Rad));
			Instantiate(createobj,pos+camera_pos,Quaternion.identity);
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {

	}
}
