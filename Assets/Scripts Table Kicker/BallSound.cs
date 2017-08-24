using UnityEngine;
using System.Collections;

public class BallSound : MonoBehaviour 
{
	AudioSource audio;

	void Start()
	{
		audio = GetComponent<AudioSource>();
       
	}


	void OnCollisionEnter (Collision collision) 
	{
		audio.Play();
	}
}