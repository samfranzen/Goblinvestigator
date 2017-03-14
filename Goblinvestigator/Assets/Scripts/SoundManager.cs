﻿using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	private AudioSource source;

	void Awake()
	{
		source = GetComponent<AudioSource>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlaySound(AudioClip clip)
	{
		source.PlayOneShot(clip);
	}
}
