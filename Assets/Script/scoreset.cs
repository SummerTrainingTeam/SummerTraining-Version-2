using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreset : MonoBehaviour
{

    public Text ScoreText;
    public int score = 0;
    // Use this for initialization

    void Start()
    {
        ScoreText = GameObject.Find("Canvas/score").GetComponent<Text>();
    }

    void Show()
    {
        ScoreText.text = "Score : " + score;
    }

    public void Add(int tmp)
    {

    }
    // Update is called once per frame
    void Update()
    {
        Show();
    }
}