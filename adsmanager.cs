using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class adsmanager : MonoBehaviour
{

    public static adsmanager instance;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showad()
    {
        if (Advertisement.IsReady("video"))
        {
            Advertisement.Show("video");
        }
    }
}
