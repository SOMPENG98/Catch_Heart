using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject pointText;
    int point = 0;

    public void GetHeart()
    {
        this.point += 1;
    }
    void Start()
    {
        this.pointText = GameObject.Find("Point");
    }


    void Update()
    {
        this.pointText.GetComponent<Text>().text = this.point.ToString() + " Heart";
    }
}
