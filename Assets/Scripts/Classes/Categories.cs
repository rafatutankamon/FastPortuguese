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

using SimpleJSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Classes
{
    public class Categories:MonoBehaviour
    {
        public static Categories instance = null;  
        public List<Category> _categories;

        public List<Category> CategoryList { get { return _categories; } }
       
        void Awake()
        {
            _categories = new List<Category>();
            //verifica se ja existe uma instancia
            if (instance == null)

                //se não seta esta instancia como a instancia ativa
                instance = this;

            //se ja existir uma instancia e não for essa
            else if (instance != this)

                //destoy essa instancia, pois não a primeira que foi criada
                Destroy(gameObject);

            //This para o editor não destruir esse objeto a cada load.
            DontDestroyOnLoad(gameObject);
            initialize();   
        }

        private void initialize()
        {
            string jsn = Resources.Load<TextAsset>("categories").text;           
            JSONNode node = JSON.Parse(jsn);    

            JSONArray categories = node["data"]["categories"].AsArray;
           // string json ="{\"ID\":1,\"Name\":\"Chars\",\"ContentType\":2,\"Dificulty\":1,\"IconPath\":\"icon.png\"}";//exemplo entrada
                         
           // Category c = Category.CreateFromJSON(json); //cria a partir do json de exemplo
          
           // string myobject = JsonUtility.ToJson(c); //pega os dados do objeto e transforma em string
            ////"{\"ID\":1,\"Name\":\"Chars\",\"ContentType\":2,\"Dificulty\":1,\"IconPath\":\"icon.png\"}" <- gerada pela chamada acima

           // Category category = JsonUtility.FromJson<Category>(myobject); //reconstroy o objeto partir da string
           // Debug.LogWarning(category.Name);
            //string json={"ID":1, "Name":"Chars", "ContentType":"2", "Dificulty":"1", "IconPath":"icon.png"};        
           
            foreach(var i in categories)
            {

                Category c = Category.CreateFromJSON(i.ToString());
               // Debug.LogWarning(i);
                 Debug.LogWarning(c.Name);
                 _categories.Add(c);
                // {"ID":"1", "Name":"Chars", "ContentType":"2", "Dificulty":"1", "IconPath":"icon.png"}

            }
            Debug.LogWarning("contem " + _categories.Count + " itens");
        }

        public void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public void CreateCategory(string name, int contentType)
        {

        }

        public void RemoveCategory(Category category)
        {
            _categories.Remove(category);
        }

        public void OrderByType() 
        {

        }
        public void OrderByDificulty()
        {

        }
    }
   // myObject = JsonUtility.FromJson<MyClass>(json);
}
