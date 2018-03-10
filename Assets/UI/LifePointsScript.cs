using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePointsScript : MonoBehaviour {

    [SerializeField]
    int LifePoints;

    [SerializeField]
    Slider slider;

    [SerializeField]
    GameMaster gameMaster;

    // Use this for initialization
    void Start()
    {
        slider.maxValue = LifePoints;
        slider.value = gameMaster.getLifePoints();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value =  gameMaster.getLifePoints();
    }
}
