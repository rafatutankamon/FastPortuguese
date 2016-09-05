using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Classes
{
    class AppScreenParameters
    {
        private float _maxWidth;  //100% of screen width
        private float _maxHeight; // 100% of screen height
        private float _headerHeight; // 10% of screen height
        private float _bodyHeight; // 90% of screen height 
        private Vector2 _catgoryContainerSize; // Size of container of category icon, 25% body height 50 % body width
        private Vector2 _itemListContainerSize;  // Size of elements of list items, must be 12,5% of body height and 100 % of body width

        public float MaxWidth { get { return _maxWidth; } }
        public float MaxHeight { get { return _maxHeight; } }
        public float HeaderHeight { get { return _headerHeight; }}
        public float BodyHeight { get { return _bodyHeight; } }
        public Vector2 CatgoryContainerSize { get { return _catgoryContainerSize; } }
        public Vector2 ItemListContainerSize { get { return _itemListContainerSize; } }

        public AppScreenParameters()
        {
            _maxWidth = Screen.width;
            _maxHeight = Screen.height;
            _headerHeight = _maxHeight / 10f;
            _bodyHeight = _maxHeight - _headerHeight;
            _catgoryContainerSize = new Vector2(_bodyHeight / 4f, _bodyHeight / 2f);
            _itemListContainerSize = new Vector2(_bodyHeight / 8f, _maxWidth);
        }
    }
}
