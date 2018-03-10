using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameMaster : MonoBehaviour {

	public GameObject octupus;
	public GameObject enemy;

	public int maxEnergy = 9;
	public float stuntime = 1;
	public float spawnTimeChangeInterval = 20;

	private ArrayList enemies;
	public Transform[] spawnLanes;
	public GameObject[] octopusArms;

	private int currentEnergy = 9;
	private float lastSpawn = 0;
	public float spawnFrequency = 2;
	private float stunTimer = 0;
	private float spawnTimeChangeTimer;

	// Use this for initialization
	void Start () {
		enemies = new ArrayList();
		spawnTimeChangeTimer = spawnTimeChangeInterval;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		spawnEnemy (Random.Range(0, 8));
		stunTimer -= Time.deltaTime;
		checkSpawnTimer ();

		if (Input.GetKeyDown("a")) {
			checkHit (0);
		}

		if (Input.GetKeyDown("s")) {
			checkHit(1);
		}

		if (Input.GetKeyDown("d")) {
			checkHit(2);
		}

		if (Input.GetKeyDown("f")) {
			checkHit(3);
		}

		if (Input.GetKeyDown("g")) {
			checkHit(4);
		}

		if (Input.GetKeyDown("h")) {
			checkHit(5);
		}

		if (Input.GetKeyDown("j")) {
			checkHit(6);
		}

		if (Input.GetKeyDown("k")) {
			checkHit(7);
		}
	}

	private void checkHit (int lane) {
		if (stunTimer <= 0) {
			octopusArms [lane].GetComponent<octopusarm> ().hit ();
			Debug.Log ("hit");
			var enemiesInHitBox = octopusArms[lane].GetComponent<octopusarm> ().enemiesInHitBox.ToArray ();

			if (enemiesInHitBox.Length > 0) {
				currentEnergy = Mathf.Min (currentEnergy + 1, maxEnergy);

				for (int i = 0; i < enemiesInHitBox.Length; i++) {
					Destroy ((GameObject)enemiesInHitBox [i]);
				}
			} else {
				currentEnergy = Mathf.Max (currentEnergy - 3, 0);

				if (currentEnergy <= 0) {
					stunTimer = stuntime;
					currentEnergy = maxEnergy;
				}
			}

			Debug.Log ("Energy: " + currentEnergy);
		} else {
			Debug.Log ("Nope");
		}
	}

	private void checkSpawnTimer() {
		spawnTimeChangeTimer -= Time.deltaTime;

		if (spawnTimeChangeTimer <= 0) {
			spawnTimeChangeTimer = spawnTimeChangeInterval;
			spawnFrequency = spawnFrequency * 0.8f;
		}
	}

	private void spawnEnemy(int lane) {
		if (Time.fixedTime - lastSpawn > spawnFrequency) {
			lastSpawn = Time.fixedTime;
			var enemyInstance = Instantiate (enemy, spawnLanes [lane].transform.position, Quaternion.identity);
			enemies.Add (enemyInstance);
		}
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

	public int getEnergy() {
		return currentEnergy;
	}
}
