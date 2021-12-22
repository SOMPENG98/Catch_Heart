using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy : MonoBehaviour
{
    GameObject director;
    
    // Start is called before the first frame update
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        this.director.GetComponent<GameDirector>().GetHeart();

        /*if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }*/
    }
}
