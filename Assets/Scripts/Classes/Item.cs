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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Classes
{
    [Serializable]
    public class Item
    {
        private int _id;
        private int _categoryId;
        private string _text;
        private string _translation;
        private string _audioPath;
        private string _imagePath; 

        //construtor vazio
        public Item()
        {

        }
        public static Item CreateFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<Item>(jsonString);
        }
        //construtor com todos parametros, audio e image são opicionais
        public Item(int id, int categoryId, string text, string translation, string audioPath = "", string imagePath = "")
        {
            this._id = id;
            this._categoryId = categoryId;
            this._text = text;
            this._translation = translation;
            this._audioPath = audioPath;
            this._imagePath = imagePath;
        }

        public int ID
        {
            get { return _id; }           
        }


        public int CategoryId
        {
            get { return _categoryId; }            
        }

        public string Text
        {
            get { return _text; }        
        }
       
        public string Translation
        {
            get { return _translation; }            
        }
        
        public string AudioPath
        {
            get { return _audioPath; }           
        }
       

        public string ImagePath
        {
            get { return _imagePath; }            
        }



    }
}
