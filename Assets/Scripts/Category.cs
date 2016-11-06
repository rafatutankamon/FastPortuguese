﻿using UnityEngine;
using System.Collections;
using Assets.Scripts.Enum;
using UnityEngine.UI;

public class Category : MonoBehaviour {

    private int _ID;
    private string _Name;
    private Type _Type;
    private Dificulty _Dificult;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void setParams(int id, string name, int type, int dificulty)
    {
        _ID = id;
        _Name = name;
        _Type = (Type)type;
        _Dificult = (Dificulty)dificulty;

        InitializeComponent();

    }

    private void InitializeComponent()
    {
        setDificultyLevel();
    }

    private void setDificultyLevel()
    {
        var image = this.gameObject.GetComponent<Image>();
        switch (this._Dificult)
        {
            case Dificulty.Very_Easy:
                image.color = Color.white;
                break;
            case Dificulty.Easy:
                image.color = Color.green;
                break;
            case Dificulty.Regular:
                image.color = Color.blue;
                break;
            case Dificulty.Hard:
                image.color = Color.yellow;
                break;
            case Dificulty.Master:
                image.color = Color.magenta;
                break;
            default:
                image.color = Color.gray;
                break;
        }
            
  
    }

    public void showCategoryItems()
    {
        Debug.LogWarning(" categoria :" + _Name + " was touched");

    }
}
