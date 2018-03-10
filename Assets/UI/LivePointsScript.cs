using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivePointsScript : MonoBehaviour {

    [SerializeField]
    int LivePoints;

    [SerializeField]
    Slider slider;

    [SerializeField]
    GameMaster gameMaster;

    // Use this for initialization
    void Start()
    {
        slider.maxValue = LivePoints;
        slider.value = gameMaster.getLivePoints();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value =  gameMaster.getLivePoints();
    }
}
