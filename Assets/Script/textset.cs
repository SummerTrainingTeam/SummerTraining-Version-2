using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class textset : MonoBehaviour
{

    public Text Blood, GameOver;
    public int a = 0;
    private int num = 100;

    // Use this for initialization

    void Start()
    {
        Blood = GameObject.Find("Canvas/blood").GetComponent<Text>();
        GameOver = GameObject.Find("Canvas/blood").GetComponent<Text>();
    }
    public void add()
    {
        num -= 10;
    }
    public void Show()
    {
        //Debug.Log(num);
        num -= a;
        Debug.Log(num);
        if (num <= 0)
        {
            GameOver.text = "GameOver";
        }
        else
        {
            Blood.text = "HP : " + num;

        }
    }

    // Update is called once per frame
    void Update()
    {
        Show();
    }
}