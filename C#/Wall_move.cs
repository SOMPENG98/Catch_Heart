using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Wall_move : MonoBehaviour
{
    public float Wall_speed = 0;
    void Start()
    {
        Destroy(gameObject, 30f);
    }

  
    void Update()
    {
        transform.Translate(Wall_speed * Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene("oppsScene");
    }
}
