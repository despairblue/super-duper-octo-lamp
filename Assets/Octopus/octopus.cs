using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class octopus : MonoBehaviour {
	[SerializeField]
	public GameMaster gameMaster;
	public int health = 10;
	public GameObject hiteffect;


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
			Instantiate (hiteffect, collider.transform.position, Quaternion.identity);
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

		gameMaster.comboCount = 0;
	}

    public bool isDead() {
        return this.health < 1;
    }
}
