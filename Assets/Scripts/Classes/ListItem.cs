using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Classes
{
    class ListItem
    {
        private float _widht;
        private float _height;
        private float _textsWidht; // represents 75% of total widht
        private float _textsHeight; // represents 66% of total height
        private float _buttonsPanelWidht; // represents 75% of total widht
        private float _buttonsPanelHeight; // represents 33% of total height
        private float _imageWidht; // represents 25% of total widht
        private float _imageHeight; // represents 98% of total height
        

        public ListItem(float widht, float height)
        {
           this._widht = widht;
           this._height = height;
           this._textsWidht = widht * 0.75f;
           this._textsHeight = height * 0.66f;
           this._imageWidht = widht * 0.25f;
           this._textsHeight = height * 0.98f;
           this._buttonsPanelHeight = height * 0.33f;
           this._buttonsPanelWidht = widht * 0.75f;
        }

        public float Width { get { return _widht; } }
        public float Height { get { return _height; } }
        public float TitleWidth { get { return _textsWidht; } }
        public float TitleHeight { get { return _textsHeight; } }
        public float ImageWidth { get { return _imageWidht; } }
        public float ImageHeight { get { return _imageHeight; } }
        public float ButtonsPanelHeight { get { return _buttonsPanelHeight; } }
        public float ButtonsPanelWidht { get { return _buttonsPanelWidht; } }

        
    }
}
