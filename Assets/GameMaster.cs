using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameMaster : MonoBehaviour {

	public GameObject octupus;
	public GameObject enemy;

	private ArrayList enemies;
	public Transform[] spawns;

	// Use this for initialization
	void Start () {
		enemies = new ArrayList();
	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject enemy in enemies) {
			enemy.transform.position += Vector3.up * 0.1f;
		}

		if (Input.GetKeyDown("a")) {
			spawnEnemy(0);
		}

		if (Input.GetKeyDown("s")) {
			spawnEnemy(1);
		}

		if (Input.GetKeyDown("d")) {
			spawnEnemy(2);
		}

		if (Input.GetKeyDown("f")) {
			spawnEnemy(3);
		}

		if (Input.GetKeyDown("g")) {
			spawnEnemy(4);
		}

		if (Input.GetKeyDown("h")) {
			spawnEnemy(5);
		}

		if (Input.GetKeyDown("j")) {
			spawnEnemy(6);
		}

		if (Input.GetKeyDown("k")) {
			spawnEnemy(7);
		}
	}

	private void spawnEnemy(int lane) {
		enemies.Add(Instantiate (enemy, spawns[lane].transform.position, Quaternion.identity));
	}

	private int getRandomLand() {
		return Random.Range (0, 8);
	}

	public int getLifePoints() {
		return 10;
	}
	
	public int getTime() {
		return 10;
	}
	
	public int getScore() {
		return 10;
	}
}
