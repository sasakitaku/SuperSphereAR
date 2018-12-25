using UnityEngine;
using System.Collections.Generic;

public class CreateSphere : MonoBehaviour {

    [SerializeField]
    private GameObject createObject;
	[SerializeField]
	private GameObject Pointer;
	// [SerializeField]
	// GetPoint getPoint; 
	private int itemCount = 10; 
    private float radius = 6f; 
	Rigidbody rigidbody;

	private int i;
	List<int> numbers = new List<int>();


    public void _CreateSpehere () {

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

			//var center = position - CenterObj.transform.position;

			int index = Random.Range(0,numbers.Count);
			int ransu = numbers[index];

			if(ransu == 1){
				//オブジェクトを精製しない
			}else {
				GameObject bullet = Instantiate(createObject,position,Quaternion.identity);
				rigidbody = bullet.GetComponent<Rigidbody>();
				rigidbody.AddForce(position*-4);
			}

			numbers.RemoveAt(index);

        }

    }
    
}
