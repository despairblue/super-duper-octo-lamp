using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class octopusarm : MonoBehaviour {
	public int enemiesInCollider = 0;
	public ArrayList enemiesInHitBox;

	// Use this for initialization
	void Start () {
		enemiesInHitBox = new ArrayList ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.CompareTag("Fish"))
		{
			enemiesInHitBox.Add (collider.gameObject);
		}
	}

	void OnTriggerExit2D(Collider2D collider) {
		enemiesInHitBox.Remove (collider.gameObject);
	}

	public void hit() {
		GetComponent<Animator> ().SetTrigger("hit");
	}
}
