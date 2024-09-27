using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class highscore : MonoBehaviour
{

    public Text Highscore;
    private int bestscore = 0;
    public void Start()
    {
        if (PlayerPrefs.HasKey("highScore"))
        {
            bestscore = PlayerPrefs.GetInt("highScore");
            Highscore.text = "Best:" + bestscore;
        }
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("highScore") < scorepanel.Scorepanel)
        {
            PlayerPrefs.SetInt("highScore", scorepanel.Scorepanel);
            bestscore = PlayerPrefs.GetInt("highScore");
            Highscore.text = "Best:" + bestscore;
        }


    }



}
