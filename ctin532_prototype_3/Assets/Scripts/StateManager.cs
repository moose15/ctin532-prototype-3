﻿using UnityEngine;
using System.Collections;

public class StateManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void playAgain()
    {
        Application.LoadLevel("menu");
    }
    public void startGame()
    {
        Application.LoadLevel("main");
    }

}
