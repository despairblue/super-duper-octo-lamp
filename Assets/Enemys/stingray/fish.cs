using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : MonoBehaviour {

	public float speed = 7;
	public float randomOffset = 6;

	// Use this for initialization
	void Start () {
		var finalSpeed = new Vector2(0, speed + Random.Range(0, randomOffset + 1));
		
		GetComponent<Rigidbody2D> ().AddForce (finalSpeed, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
