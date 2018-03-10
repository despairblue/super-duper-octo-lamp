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
<<<<<<< Updated upstream:Assets/UI/EndScoreScript.cs
        text.text = gameMaster.getScore().ToString();
=======
        slider.maxValue = LivePoints;
        slider.value = gameMaster.getLifePoints();
>>>>>>> Stashed changes:Assets/UI/LivePointsScript.cs
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream:Assets/UI/EndScoreScript.cs
        text.text = gameMaster.getScore().ToString();
=======
        slider.value =  gameMaster.getLifePoints();
>>>>>>> Stashed changes:Assets/UI/LivePointsScript.cs
    }
}
