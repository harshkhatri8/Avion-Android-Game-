using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changepanlename : MonoBehaviour
{


    public Button L1, L2, L3;
    public GameObject g1, g2, g3,s20,s40;



    public void Start()
    {
       
        L2.interactable = false;
        L3.interactable = false;
    }

    public void restart()
    {

        SceneManager.LoadScene(0);
        score.Score = 0;
        scorepanel.Scorepanel = 0;

        
    }
    public void playgame()
    {
        SceneManager.LoadScene(1);
        score.Score = 0;
        scorepanel.Scorepanel = 0;

       
        
    }

    public void blocks()
    {
        SceneManager.LoadScene(1);
        score.Score = 0;
        scorepanel.Scorepanel = 0;

       
        
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
        scorepanel.Scorepanel = 0;


        
    }
    public void mountain()
    {
        SceneManager.LoadScene(2);
        scorepanel.Scorepanel = 0;


        
    }

    public void Lollipop()
    {
        SceneManager.LoadScene(4);
        scorepanel.Scorepanel = 0;


        
    }



    public void quit()
    {

        Application.Quit();

    }



   public void next1()
    {
        g1.SetActive(false);
        g2.SetActive(true);
        g3.SetActive(false);
    }
    public void next2()
    {
        g1.SetActive(false);
        g2.SetActive(false);
        g3.SetActive(true);
    }
    public void back1()
    {
        g1.SetActive(true);
        g2.SetActive(false);
        g3.SetActive(false);
    }



    private void Update()
    {
        if (PlayerPrefs.GetInt("highScore") < 30)
        {

            s20.SetActive(true);
            s40.SetActive(true);

        }
        else if (PlayerPrefs.GetInt("highScore") >= 30)
        {

            L2.interactable = true;
            L3.interactable = false;
            s20.SetActive(false);
            s40.SetActive(true);
        }

        

        else if (PlayerPrefs.GetInt("highScore") >= 60)
        {

            L2.interactable = true;
            L3.interactable = true;
            s20.SetActive(false);
            s40.SetActive(false);
        }



    }




}
