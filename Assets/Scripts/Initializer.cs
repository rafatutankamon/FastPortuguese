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
using UnityEngine.UI;
using Assets.Classes;
using System.Linq;
using System.Collections.Generic;
using SimpleJSON;
using Assets.Scripts.Classes;
public class Initializer : MonoBehaviour {
    //private 
    private AppScreenParameters _parameters;
    private string _json;

    //public
    public Canvas CANVAS;
   // public GameObject listItemPrefab;
    public GameObject categoryItemPrefab;
   // public GameObject grid_Itens;
    public GameObject grid_Categories;
    public GameObject body;
    public GameObject header;
 
	void Start () 
    {
      //private AppScreenParameters _parameters;
       _parameters = new AppScreenParameters();
       ScaleAdjustPrefabs();
       CreateCategories();
       //LoadJson();
       //var gd = content.GetComponent<RectTransform>();
       //var cs = content.GetComponent<ContentSizeFitter>();
       //Debug.LogWarning("initial height " + gd.rect.height);
       //_json = LoadResourceTextfile("categories.json");
      // string jsn = Resources.Load<TextAsset>("categories").text;
      // //JsonData jsonBooks = JsonMapper.ToObject(jsn);
      // JSONNode node = JSON.Parse(jsn);
      //// var name = from c in node["data"]["categories"][0]["name"] select c;
      // JSONArray categories = node["data"]["categories"].AsArray;
      // CreateCategoryItens();
      /*
       for (var i = 0; i < categories.Count;i++ )
       {

          // Debug.LogWarning("nome : " + node["data"]["categories"][i]["name"] + " cor :" + node["data"]["Categories"][i]["color"]);
           GameObject go = Instantiate(categoryItemPrefab, new Vector3(i, i, 0), Quaternion.identity) as GameObject;
           go.transform.SetParent(grid_Categories.transform);
           var id = node["data"]["categories"][i]["id"].AsInt;
           string name = node["data"]["categories"][i]["name"];
           var type = node["data"]["categories"][i]["type"].AsInt;
           var dificulty = node["data"]["categories"][i]["dificulty"].AsInt;
           go.GetComponentInChildren<Text>().text= name;
           go.GetComponent<CategoryItem>().setParams(id,name,type,dificulty);
       }*/
       
       
       
   
       //Debug.LogWarning("name" + name);
       
   	}

    /*private void LoadJson()
    {
        string jsn = Resources.Load<TextAsset>("categories").text;
        //JsonData jsonBooks = JsonMapper.ToObject(jsn);
        JSONNode node = JSON.Parse(jsn);
        // var name = from c in node["data"]["categories"][0]["name"] select c;
        JSONArray categories = node["data"]["categories"].AsArray;
        CreateCategories();
    }*/
	
   /* void CreateCategoryItens(string optionalCategory = "favoritos")
    {
       
               
    }*/
    void CreateCategories()
    {
        var loopIndex = 0;
        var objIndex = -1;
        float headSpacingAdd = _parameters.HeaderHeight;
        List<GameObject> categoryCell = new List<GameObject>();
        foreach (var c in Categories.instance.CategoryList)
       // for (var i = 0; i <= 20;i++ )
        {
            if(IsEven(loopIndex))
            {
                GameObject go = Instantiate(categoryItemPrefab, new Vector3(0, (loopIndex * _parameters.CatgoryContainerSize.y), 0), Quaternion.identity) as GameObject;
                go.transform.SetParent(grid_Categories.transform);
                go.transform.localScale = new Vector3(1f, 1f, 1f);
                categoryCell.Add(go);
                objIndex += 1;
                GameObject leftChild= go.transform.FindChild("__LeftItem").gameObject;
                leftChild.GetComponentInChildren<Text>().text = c.Name;
                leftChild.GetComponent<CategoryItem>().setParams(c.ID, c.Name, c.ContentType, c.Dificulty, c.IconPath);
            }
            else
            {
                GameObject rightChild = categoryCell[objIndex].transform.FindChild("__RightItem").gameObject;
                rightChild.GetComponentInChildren<Text>().text = c.Name;
                rightChild.GetComponent<CategoryItem>().setParams(c.ID, c.Name, c.ContentType, c.Dificulty, c.IconPath);
            }
           //
            //go.GetComponentInChildren<Text>().text = c.Name;
           // go.GetComponent<CategoryItem>().setParams(c.ID, c.Name, c.ContentType, c.Dificulty, c.IconPath);
            loopIndex += 1;
        }
        if(IsEven(loopIndex))
        {
            categoryCell[objIndex].transform.FindChild("__RightItem").gameObject.SetActive(false);
        }
    }

    
    private void ScaleAdjustPrefabs()
    {
        var rt = categoryItemPrefab.GetComponent<RectTransform>();
        rt.sizeDelta = _parameters.CatgoryContainerSize;
        //header.GetComponentInChildren<Text>().text = _parameters.MaxWidth + " x " + _parameters.MaxHeight +"-"+ _parameters.CatgoryContainerSize.x +" "+_parameters.CatgoryContainerSize.y;
       // header.GetComponent<RectTransform>().sizeDelta = new Vector2(_parameters.MaxWidth, _parameters.HeaderHeight);
        /*var grid = grid_Categories.GetComponent<GridLayoutGroup>();
        float space = _parameters.CatgoryContainerSize.x + (_parameters.CatgoryContainerSize.x * 0.15f);
        int padding = (int)(_parameters.HeaderHeight + (_parameters.HeaderHeight * 0.65f));
        grid.cellSize = _parameters.CatgoryContainerSize;
        grid.spacing = new Vector2(space, space);
        grid.padding.top = padding;
        grid.padding.bottom = padding;*/
       // grid_Categories.GetComponent<GridLayoutGroup>().spacing = new Vector2(_parameters.CatgoryContainerSize.x,_parameters.CatgoryContainerSize.y);
       // grid_Categories.GetComponent<GridLayoutGroup>().padding = new RectOffset(10, 10, 5, 5);
        // CANVAS.GetComponent<RectTransform>().sizeDelta = new Vector2(_parameters.MaxWidth, _parameters.MaxHeight);
      /*  body.GetComponent<RectTransform>().sizeDelta = new Vector2(_parameters.MaxWidth,_parameters.BodyHeight);
        
        //header.GetComponent<RectTransform>().sizeDelta = new Vector2(_parameters.MaxWidth, _parameters.HeaderHeight);
        header.GetComponentInChildren<Text>().text = _parameters.MaxWidth + " x " + _parameters.MaxHeight;
        listItemPrefab.GetComponent<RectTransform>().offsetMax = Vector2.zero;
        listItemPrefab.GetComponent<RectTransform>().offsetMin = Vector2.zero;
        listItemPrefab.GetComponent<RectTransform>().sizeDelta =_parameters.ItemListContainerSize;
        categoryItemPrefab.GetComponent<RectTransform>().sizeDelta = _parameters.CatgoryContainerSize;
        */

        //CreateCategoryItens();
       // CreateCategories();
       
    }
    public bool IsEven(int value)
    {
        return value % 2 == 0;
    }
 
}
