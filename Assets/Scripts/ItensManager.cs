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

public class ItensManager : MonoBehaviour {

    public Text categoryName;
    public GameObject prefabType1;
    public GameObject prefabType2;
    public GameObject prefabType3;

    void Awake()
    {

    }
    // Use this for initialization
    void Start()
    {
        categoryName.text = ScreenManager.Instance.getCategoryName();
        ScaleAdjustPrefabs();
        foreach (var c in Categories.instance.CategoryList)
        {
            CreateCategoryItens(c);
        }
        
    }
    void CreateCategoryItens(Category category)
    {
        foreach(var c in Categories.instance.CategoryList)
        {
            var go = GetPrefabToInstantiate((ContentType)c.ContentType);
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

    }
}
