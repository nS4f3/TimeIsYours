using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster2D : MonoBehaviour
{
    public Text score;
    public static float scorenum;

    private void Awake() {
        scorenum = 0;
    }


    private void Update() {
        score.text = scorenum.ToString();
    }
    
}
