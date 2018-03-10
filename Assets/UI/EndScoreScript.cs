using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScoreScript : MonoBehaviour {

    [SerializeField]
    Text text;

    [SerializeField]
    GameMaster gameMaster;

    // Use this for initialization
    void Start()
    {
        text.text = "Final Score: " + gameMaster.getScore();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Final Score: " + gameMaster.getScore();
    }
}
