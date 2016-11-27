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
        category = new Category(id, name, type, dificulty, iconPath);
        //_ID = id;
        //_Name = name;
        //_ContentType = (ContentType)type;
        //_Dificult = (Dificulty)dificulty;

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
        ScreenManager.instance.navigateToCategory(category);
    }
}
