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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Classes
{
    /*This class will help the app keep same aspect ratio of UI elements */
    public class AppScreenParameters
    {
        private float _maxWidth;  //100% of screen width
        private float _maxHeight; // 100% of screen height
        private float _headerHeight; // 10% of screen height
        private float _bodyHeight; // 90% of screen height 
        private Vector2 _catgoryContainerSize; // Size of container of category icon, 25% body height 50 % body width
        private Vector2 _itemListContainerSize;  // Size of elements of list items, must be 12,5% of body height and 100 % of body width
        private ListItem _listItem;

        public float MaxWidth { get { return _maxWidth; } }
        public float MaxHeight { get { return _maxHeight; } }
        public float HeaderHeight { get { return _headerHeight; }}
        public float BodyHeight { get { return _bodyHeight; } }
        public Vector2 CatgoryContainerSize { get { return _catgoryContainerSize; } }
        public Vector2 ItemListContainerSize { get { return _itemListContainerSize; } }
        public ListItem ListItem { get { return _listItem; } }

        public AppScreenParameters()
        {
            this._maxWidth = Screen.width;
            this._maxHeight = Screen.height;
            this._headerHeight = _maxHeight / 10f;
            this._bodyHeight = _maxHeight - _headerHeight;
            this._catgoryContainerSize = new Vector2(_maxWidth * 0.5f,_bodyHeight * 0.25f);
            this._itemListContainerSize = new Vector2( _maxWidth ,_bodyHeight * 0.2f);
            this._listItem = new ListItem(_itemListContainerSize.x, _itemListContainerSize.y);
            //ListItem =  new ListItem();
        }
    }
}
