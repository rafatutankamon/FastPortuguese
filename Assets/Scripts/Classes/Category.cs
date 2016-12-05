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

using Assets.Scripts.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Classes
{
    [System.Serializable]
    public class Category
    {
        /*private int _categoryId;
        private string _name;
        private ContentType _contentType;
        private Dificulty _dificulty;
        private string _iconPath;
        private List<Item> _categoryItens;

        public int ID { get { return _categoryId; } }
        public string Name { get { return _name; } }
        public ContentType ContentType { get { return _contentType; } }
        public Dificulty Dificulty { get { return _dificulty; } }
        public string IconPath { get { return _iconPath; } }
        public List<Item> ItensList { get { return _categoryItens; } }
        */

        public List<Item> ItensList { get { return ItensList; } }
        public int ID;
        public string Name;
        public int ContentType;
        public int Dificulty;
        public string IconPath;
        
        
        public static Category CreateFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<Category>(jsonString);
        }
       

        public Category(int id, string name, int contentType, int dificulty, string iconPath)
        {
            this.ID = id;
            this.Name = name;
            this.ContentType = contentType;
            this.Dificulty = dificulty;
            this.IconPath = iconPath;
        }

        //o item será adicionado após instanciado com os parâmetros corretos.
        private void AddItem(Item item)
        {
            ItensList.Add(item);
        }

        public void CreateItem(string text, string translation, string audioPath ="" , string imagePath ="")
        {
            //gera o ID do item = ID categoria + numero de itens da lista + 1
            int id = (this.ID * 1000) + (ItensList.Count + 1);
            Item item = new Item(id,ID,text,translation,audioPath,imagePath);

            //adiciona o item instanciado na lista de itens
            AddItem(item);
        }
        
    }
}
