﻿using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public void back()
    {
        ScreenManager.instance.backToPreviousScreen();
    }
	// Update is called once per frame
	void Update () {
	
	}
}
