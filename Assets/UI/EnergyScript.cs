using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyScript : MonoBehaviour {

        [SerializeField]
        int Energy;

        [SerializeField]
        Slider slider;

        [SerializeField]
        GameMaster gameMaster;

        // Use this for initialization
        void Start()
        {
            slider.maxValue = Energy;
            slider.value = gameMaster.getEnergy();
        }

        // Update is called once per frame
        void Update()
        {
            slider.value = gameMaster.getEnergy();
        }

}
