using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : MonoBehaviour {

	public Vector2 speed = new Vector2(0, 10);

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().AddForce (speed, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
