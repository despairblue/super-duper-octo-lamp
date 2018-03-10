using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenScript : MonoBehaviour {

    public GameMaster gameMaster;

    public Image EndScreen;

	// Use this for initialization
	void Start () {
        EndScreen.enabled = false;

        for (int i = 0; i < EndScreen.transform.childCount; i++)
        {
            var child = EndScreen.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (gameMaster.getTime() < 1) {
            EndScreen.enabled = true;

            for (int i = 0; i < EndScreen.transform.childCount; i++)
            {
                var child = EndScreen.transform.GetChild(i).gameObject;
                if (child != null)
                    child.SetActive(true);
            }
        }

    }
}
