using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class movement : MonoBehaviour
{

    
    private float velocity = 2.8f;
    public float rotatingspeed = 55f;
    public float rotatingspee = -10f;
    public Rigidbody2D rb;
    public float movespeed = 20;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
            transform.Rotate(0f, 0f, 22f);


        }

        if (Input.GetMouseButtonUp(0))
        {

            transform.Rotate(0f, 0f, -22f);

        }





    }
        void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag == "blocks")
        {
            Destroy(gameObject);

            SceneManager.LoadScene(3);
            
            score.Score = 0;

            
        }  

    }


}


