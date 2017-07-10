using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinset : MonoBehaviour {

    public Text Coin;
    private int num = 0;

	// Use this for initialization
	void Start () {
        Coin = GameObject.Find("Canvas/coin").GetComponent<Text>();
        //Coin.text = " " + num;
	}
	
    public void Add(int tmp)
    {
        num += tmp;
    }

    public void Show()
    {
        Coin.text = " " + num;
    }

	// Update is called once per frame
	void Update () {
        Show();
	}
}
