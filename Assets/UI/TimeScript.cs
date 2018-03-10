﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    [SerializeField]
    Text text;

    [SerializeField]
    GameMaster gameMaster;

    // Use this for initialization
    void Start()
    {
        text.text = "Time: " + gameMaster.getTime();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Time: " + gameMaster.getTime();
    }
}
