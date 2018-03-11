using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameMaster : MonoBehaviour {

	public GameObject octupusInstance;
	public GameObject enemy;

	public int maxEnergy = 9;
	public float stuntime = 1;
	public float spawnTimeChangeInterval = 20;

	public int score = 0;
	public int comboCount = 0;
	public int comboMultiplier = 1;

	private ArrayList enemies;
	public Transform[] spawnLanes;
	public GameObject[] octopusArms;
	public GameObject hiteffect;

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
	void Update () {
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
	
	void FixedUpdate () {
		spawnEnemy (Random.Range(0, 8));
		stunTimer -= Time.fixedDeltaTime;
		checkSpawnTimer ();
		checkStunned();

	}

	private void scoring() {
		comboCount++;

		if (comboCount < 4) {
			comboMultiplier = 1;
		} else if (comboCount >= 4 && comboCount < 8) {
			comboMultiplier = 2;
		} else {
			comboMultiplier = 3;
		}

		score += 100 * comboMultiplier;
	}

	private void checkStunned () {
		if (stunTimer <= 0) {
			octupusInstance.GetComponent<Animator> ().SetBool("stunned", false);
		} else {
			octupusInstance.GetComponent<Animator> ().SetBool ("stunned", true);
		}
	}

	private void checkHit (int lane) {
		if (stunTimer <= 0) {
			octopusArms [lane].GetComponent<octopusarm> ().hit ();

			var enemiesInHitBox = octopusArms[lane].GetComponent<octopusarm> ().enemiesInHitBox.ToArray ();

			if (enemiesInHitBox.Length > 0) {
				scoring ();
				currentEnergy = Mathf.Min (currentEnergy + 1, maxEnergy);

				for (int i = 0; i < enemiesInHitBox.Length; i++) {
					Instantiate (hiteffect, ((GameObject)enemiesInHitBox [i]).transform.position, Quaternion.identity);
					
					Destroy ((GameObject)enemiesInHitBox [i]);
				}
			} else {
				currentEnergy = Mathf.Max (currentEnergy - 3, 0);
				comboCount = 0;

				if (currentEnergy <= 0) {
					stunTimer = stuntime;
					currentEnergy = maxEnergy;
				}
			}

			Debug.Log ("Energy: " + currentEnergy);
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
		return octupusInstance.GetComponent<octopus>().health;
	}
	
	public int getTime() {
		return Mathf.RoundToInt(Time.fixedTime);
	}
	
	public int getScore() {
		return score;
	}

	public int getEnergy() {
		return currentEnergy;
	}
}
