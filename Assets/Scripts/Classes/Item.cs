using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
