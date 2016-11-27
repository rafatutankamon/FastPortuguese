using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class VisualizeImage : MonoBehaviour
    {
        private string imagePath;
        void Awake()
        {

        }
        void Start()
        {
            LoadImage();
        }
        public void LoadImage()
        {
            Close();
        }
        public void Close()
        {
            ScreenManager.BackToPreviousLevel();
        }
    }
}
