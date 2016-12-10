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
using Assets.Scripts.Classes;
using Assets.Scripts.Enum;
using System.Linq;
using Assets.Classes;
public class ItensManager : MonoBehaviour {

    public Text categoryName;
    public GameObject prefabType1;
    public GameObject gridItens;
   /* public GameObject prefabType2;
    public GameObject prefabType3;*/
    AppScreenParameters _parameters;
    void Awake()
    {
        _parameters = new AppScreenParameters();
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
            ScreenManager.Instance.navigateToLevel(1, UnityEngine.SceneManagement.LoadSceneMode.Single);
    }
    // Use this for initialization
    void Start()
    {
        // categoryName.text = ScreenManager.Instance.getCategoryName();
        ScaleAdjustPrefabs();
        
        Category cat = Categories.instance._categories.First(c => c.ID == ScreenManager.Instance.getCategoryID());
        CreateCategoryItens(cat);
        /*for(var x = 0; x<=20; x++)
        {
            GameObject go = Instantiate(prefabType1, new Vector3(0, (x * _paramenters.ItemListContainerSize.y), 0), Quaternion.identity) as GameObject;
            go.transform.SetParent(gridItens.transform);
            go.transform.localScale = new Vector3(1f, 1f, 1f);
        }*/
    }
    void CreateCategoryItens(Category category)
    {
        var x = 0;
        foreach(var c in category.ItensList)
        {
            //var go = GetPrefabToInstantiate(ContentType.Text);
            GameObject go = Instantiate(prefabType1, new Vector3(0, (x * _parameters.ItemListContainerSize.y), 0), Quaternion.identity) as GameObject;
            go.transform.SetParent(gridItens.transform);
            go.transform.localScale = new Vector3(1f, 1f, 1f);
            //go.GetComponent
            x += 1;
        }
        
    }
    public GameObject GetPrefabToInstantiate(ContentType type)
    {
        switch (type)
        {
            case ContentType.Text:
                return prefabType1;
                break;
            case ContentType.Text_Image:
                return prefabType1;
                break;
            case ContentType.Text_Image_Sound:
                return prefabType1;
                break;
            default : return prefabType1;
        }
    }
    public void ScaleAdjustPrefabs()
    {
        var rt = prefabType1.GetComponent<RectTransform>();
        rt.sizeDelta = _parameters.ItemListContainerSize;
    }
}
