using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetPoint : MonoBehaviour {
	[SerializeField]
	CreateSphere createSphere;
	[SerializeField]
	Text ScoreText;
	[SerializeField]
	GameObject pointParticle;
	[SerializeField]
	AudioClip pointSound;
	private AudioSource audioSource;
	int score = 0;


	// Use this for initialization
	void Start () {
		ScoreText = ScoreText.GetComponent<Text>();
		ScoreText.text = "Score:"+score;
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		ScoreText.text = "Score:"+score;		
	}

	void OnCollisionEnter (Collision col)
    {
		if(col.gameObject.tag == "Bullet")
		{
			score++;

			Instantiate(pointParticle,col.gameObject.transform);

			audioSource.PlayOneShot(pointSound);

			GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
			foreach(var bullet in bullets){
				Destroy(bullet);
			}

			createSphere._CreateSpehere();
		}
    }
}
