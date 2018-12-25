using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UniRx;
using System;

public class GameController : MonoBehaviour {
	[SerializeField]
	GameObject gameoverParticle;
	[SerializeField]
	AudioClip gameoverSound;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag == "Bullet")
        {
			Instantiate(gameoverParticle,col.gameObject.transform);
			
			audioSource.PlayOneShot(gameoverSound);

			GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
			foreach(var bullet in bullets){
				Destroy(bullet);
			}

			Observable.Timer(TimeSpan.FromSeconds(1)).Subscribe(_ =>
			{
				SceneManager.LoadScene("GameOver");
			}).AddTo(this);
        }
    }
}
