using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int Score;


    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        GetComponent<Text>().text = Score.ToString();


    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Score +=1;
    }
}
