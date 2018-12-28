using UnityEngine;
using System.Collections.Generic;

public class CreateSphere : MonoBehaviour {

    [SerializeField]
    private GameObject createobj;
	[SerializeField]
	Camera camera; 
	Vector3 pos;
	int itemCount = 100;
	int radius = 4;
	int i;
	float angle1;
	float angle2;
	//List<int> numbers = new List<int>();
    public void _CreateSpehere () {

		Vector3 camera_pos = camera.transform.position;
		for (i = 0; i < itemCount; ++i)
		{
			angle1 = Random.Range(0,360);
			angle2 = Random.Range(0,360);
			pos = new Vector3(radius*Mathf.Sin(angle2*Mathf.Deg2Rad)*Mathf.Cos(angle1*Mathf.Deg2Rad),
		    radius*Mathf.Cos(angle2*Mathf.Deg2Rad),radius*Mathf.Sin(angle2*Mathf.Deg2Rad)*Mathf.Sin(angle1*Mathf.Deg2Rad));
			Instantiate(createobj,pos+camera_pos,Quaternion.identity);
		}

        // var oneCycle = 2.0f * Mathf.PI;

		// for (i = 0; i < itemCount; ++i)
		// {
		// 	numbers.Add(i);
		// } 

        // for (i = 0; i < itemCount; ++i)
        // {
		// 	var point = (i / itemCount) * oneCycle; 
        //     var x = Mathf.Cos(point) * radius;
        //     var z = Mathf.Sin(point) * radius;

        //     var position = new Vector3(x, 0, z);

		// 	var center = position + camera.transform.position;

		// 	int index = Random.Range(0,numbers.Count);
		// 	int ransu = numbers[index];

		// 	if(ransu == 1){
		// 		//オブジェクトを精製しない
		// 	}else {
		// 		GameObject bullet = Instantiate(createObject,center,Quaternion.identity);
		// 	}

		// 	numbers.RemoveAt(index);
        // }
    }
}
