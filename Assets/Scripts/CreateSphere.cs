﻿using UnityEngine;
using System.Collections.Generic;

public class CreateSphere : MonoBehaviour {

    [SerializeField]
    private GameObject createObject;
	[SerializeField]
	Camera camera; 
	[SerializeField]
	GameObject Center;
	private int itemCount = 8; 
    private float radius = 5f; 
	Rigidbody rigidbody;
	private int i;
	List<int> numbers = new List<int>();


    public void _CreateSpehere () {

		Center.transform.position = camera.transform.position;

        var oneCycle = 2.0f * Mathf.PI;

		for (i = 0; i < itemCount; ++i)
		{
			numbers.Add(i);
		} 

        for (i = 0; i < itemCount; ++i)
        {
			var point = ((float)i / itemCount) * oneCycle; 
            var x = Mathf.Cos(point) * radius;
            var z = Mathf.Sin(point) * radius;

            var position = new Vector3(x, 0, z);

			var center = position + camera.transform.position;

			int index = Random.Range(0,numbers.Count);
			int ransu = numbers[index];

			if(ransu == 1){
				//オブジェクトを精製しない
			}else {
				GameObject bullet = Instantiate(createObject,center,Quaternion.identity);
				rigidbody = bullet.GetComponent<Rigidbody>();
				rigidbody.AddForce(position*-4);
			}

			numbers.RemoveAt(index);

        }

    }
    
}
