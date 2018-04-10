﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof (AudioSource))]

public class CoconutWin : MonoBehaviour {
	public static int targets = 0;
	public static bool haveWon = false;
	public AudioClip winSound;
	public GameObject cellPrefab;
	AudioSource audio;


	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(targets==3 && haveWon == false){
			targets = 0;
			audio.PlayOneShot(winSound);
			GameObject winCell = transform.Find("powerCell").gameObject;
			winCell.transform.Translate(-1,0,0);
			Instantiate(cellPrefab, winCell.transform.position,
				transform.rotation);
			Destroy(winCell);
			haveWon = true;
		}
	}
}
