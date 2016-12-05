/*Copyright (C) <2016>  <Rafael Quevedo Pereira>

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation; either version 2 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA*/

using UnityEngine;
using System.Collections;
using Assets.Scripts.Enum;
using UnityEngine.UI;
using Assets.Scripts.Classes;

public class CategoryItem : MonoBehaviour {

    private Category category;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void setParams(int id, string name, int type, int dificulty, string iconPath)
    {
        Debug.LogWarning("dificulty : "+dificulty);
        category = new Category(id, name, type, dificulty, iconPath);
        InitializeComponent();

    }

    private void InitializeComponent()
    {
        setDificultyLevel();
        //set icon
    }

    private void setDificultyLevel()
    {
        var image = this.gameObject.GetComponent<Image>();

        
        switch ((Dificulty)this.category.Dificulty)
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
       // Debug.LogWarning(" categoria :" + _Name + " was touched");
        ScreenManager.Instance.navigateToCategory(category);
    }
}
