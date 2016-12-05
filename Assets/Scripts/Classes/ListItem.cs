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

namespace Assets.Scripts.Classes
{
    public class ListItem
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
