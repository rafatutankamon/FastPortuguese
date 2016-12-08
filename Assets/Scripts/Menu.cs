﻿/*Copyright (C) <2016>  <Rafael Quevedo Pereira>

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

namespace Assets.Scripts
{
    class Menu : MonoBehaviour
    {
        public List<Item> _favorites;
        public static Menu instance = null;  
        void Awake()
        {          
            _favorites = new List<Item>();
            //verifica se ja existe uma instancia
            if (instance == null)

                //se não seta esta instancia como a instancia ativa
                instance = this;

            //se ja existir uma instancia e não for essa
            else if (instance != this)

                //destoy essa instancia, pois não a primeira que foi criada
                Destroy(gameObject);

            //This para o editor não destruir esse objeto a cada load.
            DontDestroyOnLoad(gameObject);
            //initialize();   
        
        }
        void Start()
        {

        }

        public void ShowFavorites()
        {

        }
        public void AddFavorite(Item favorite)
        {
            _favorites.Add(favorite);
        }
        public void RemoveFavorite(Item favorite)
        {
            _favorites.Remove(favorite);
        }
        public void ShowAbout()
        {

        }
        public void ShowTexts()
        {

        }
        public void OpenMenu()
        {

        }
        public void CloseMenu()
        {

        }
        
    }
}
