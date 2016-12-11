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
using UnityEngine.UI;

namespace Assets.Scripts
{
    class CategorySubItem : MonoBehaviour
    {
        public Text Text;
        public Text Translation;
        public Image btn_Favorite;
        /*public Image btn_Play;
        public Image btn_Pause;
        public Image btn_Stop;*/
        public Image itemImage;
        public Item item;

        void Awake()
        {

        }
        void Start()
        {

        }
        void Update()
        {

        }

        public void Initialize(Item categoryitem)
        {
            item.Clone(categoryitem);
            Text.text = item.Text;  
            Translation.text = item.Translation;
            Sprite newSprite =  Resources.Load <Sprite>(item.ImagePath);
            if (newSprite){
                itemImage.sprite = newSprite;
            } else {
                //itemImage.sprite
            }
            

        }
        public void SetDificulty()
        {

        }
        public void EnableAudioPlay()
        {

        }
        public void DisableAudioPlay()
        {

        }
        public void VisualizeImage()
        {
            var level = Application.loadedLevelName;
            //Debug.LogWarning(level + " last level loaded");
            ScreenManager.Instance.setLastLevel(level);
            ScreenManager.Instance.NavigateToImageScene(this.item);
        }
        public void AddToFavorites()
        {
            
        }
        public void PlayAudio()
        {
            

        }
        public void PauseAudio()
        {
            
        }
        public void StopAudio()
        {
            
        }
        
    }
}
