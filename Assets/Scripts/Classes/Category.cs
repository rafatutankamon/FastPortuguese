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
       /* private int _categoryId;
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
        public int ID;
        public string Name;
        public int ContentType;
        public int Dificulty;
        public string IconPath;

        public static Category CreateFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<Category>(jsonString);
        }
        //public static PlayerInfo CreateFromJSON(string jsonString)
        //{
        //    return JsonUtility.FromJson<PlayerInfo>(jsonString);
        //}

        /*public Category(int id, string name, int contentType, int dificulty, string iconPath)
        {
            this._categoryId = id;
            this._name = name;
            this._contentType = (ContentType)contentType;
            this._dificulty = (Dificulty)dificulty;
            this._iconPath = iconPath;
        }

        //o item será adicionado após instanciado com os parâmetros corretos.
        private void AddItem(Item item)
        {
            _categoryItens.Add(item);
        }

        public void CreateItem(string text, string translation, string audioPath ="" , string imagePath ="")
        {
            //gera o ID do item = ID categoria + numero de itens da lista + 1
            int id = (this._categoryId * 1000) + (_categoryItens.Count + 1);
            Item item = new Item(id,_categoryId,text,translation,audioPath,imagePath);

            //adiciona o item instanciado na lista de itens
            AddItem(item);
        }*/
        
    }
}
