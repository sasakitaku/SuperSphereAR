using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameStart : MonoBehaviour {
	[SerializeField]
	GameObject GameStartBtn;
	[SerializeField]
	CreateSphere createSphere;
	
	
	// Use this for initialization
	void Start () { 
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void _GameStart(){
		createSphere._CreateSpehere();
		GameStartBtn.SetActive(false);
	}
}
