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

using Assets.Scripts.Classes;
using SimpleJSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    class SplashBehaviour : MonoBehaviour
    {
        JSONArray categories;
        JSONArray categoryItens;
        List<Item> catItens;
        void Awake()
        {
            this.gameObject.AddComponent<ScreenManager>();

        }
        void Start()
        {
            List<Item> catItens = new List<Item>();
            ShowLoading();
            TryLoadJSON();
        }
        void TryLoadJSON()
        {
            
            try
            {
                string jsn = Resources.Load<TextAsset>("categories").text;
                JSONNode node = JSON.Parse(jsn);
                categories = node["data"]["categories"].AsArray;

                string jsnItens = Resources.Load<TextAsset>("categoryItens").text;
                JSONNode nodeItens = JSON.Parse(jsnItens);
                categoryItens = nodeItens["data"]["categoriyItens"].AsArray;
              
                //se estiver td ok 
                SaveBackupJSON();
                CreateCategories();
            }
            catch (Exception e)
            {
                Debug.LogWarning(e);
                RestoreBackupJSON();
            } 
                
            
        }
        void SaveBackupJSON()
        {
            //verificr versao do json, se for diferente gravar backup
            Debug.LogWarning("gravar backup");
        }
        void RestoreBackupJSON()
        {
            Debug.LogWarning("restaurando backup.");
            TryLoadJSON();
        }
        public void CreateCategories()
        {

            foreach (var i in categories)
            {
                Category c = Category.CreateFromJSON(i.ToString());
                //Categories.instance.AddCategory(c);
                CreateCategoryItens(c);
            }            
           
            HideLoading();
        }
        public void CreateCategoryItens(Category category)
        {     
            if(catItens.Count < 1)
            {
                //cria uma lista de todos itens de categoria do JSON
                foreach (var i in categoryItens)
                {
                    Item c = Item.CreateFromJSON(i.ToString());
                    catItens.Add(c);
                }
            }
            //seleciona apenas os itens referentes a categoria
            /*var itens =
                from item in catItens
                where item.CategoryId = category.ID
                select item;*/
            List<Item> filter = catItens.Where(c => c.CategoryId == category.ID).ToList();
            foreach (var c in filter)
            {                
                category.CreateItem(c.Text,c.Translation,c.AudioPath,c.ImagePath);
            }
            //adicioa a categoria com os itens na instancia do categories.
            Categories.instance.AddCategory(category);
        }

        public void ShowError()
        {

        }
        public void ShowLoading()
        {

        }
        public void HideLoading()
        {
            FinishSplash();
        }
        void FinishSplash()
        {
            var level = Application.loadedLevelName;
            ScreenManager.Instance.setLastLevel(level);
            ScreenManager.Instance.navigateToLevel(1, LoadSceneMode.Single);
            //call sreenmanger to change level
        }
    }
}
