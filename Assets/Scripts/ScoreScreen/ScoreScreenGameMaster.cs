using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScreenGameMaster : MonoBehaviour
{

    public Text score;
    
    // Start is called before the first frame update
    void Start()
    {  

        score.text = GameMaster2D.scorenum.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            SceneManager.LoadScene(1);

        }
        else if(Input.GetMouseButton(1)){
            SceneManager.LoadScene(0);
        }
    }
}
