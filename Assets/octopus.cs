﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class octopus : MonoBehaviour {

	public int health = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.CompareTag("Fish"))
		{
			Destroy(collider.gameObject);

			ApplyDamage();
		}
	}
		
	void ApplyDamage()
	{
		health -= 1;

		Debug.Log("Take Damage");

		if (health <= 0){
			Debug.Log("GameOver");
		}
	}
}
