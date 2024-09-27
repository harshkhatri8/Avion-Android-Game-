using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scorepanel : MonoBehaviour
{

    public static int Scorepanel;



    // Start is called before the first frame update

    public void Start()
    {



    }
    // Update is called once per frame
    public void Update()
    {
        GetComponent<Text>().text = Scorepanel.ToString();
          
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Scorepanel += 1;
    }
}
