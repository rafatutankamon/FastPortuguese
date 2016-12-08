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

using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Assets.Scripts.Classes;
using Assets.Classes;       //Allows us to use Lists. 

      
public class ScreenManager : MonoBehaviour
{

        private static ScreenManager _instance = null;              //Static instance of ScreeManager which allows it to be accessed by any other script.
        public AppScreenParameters _parameters;
                                      
        private string lastLevel;
        private int CategoryId;
        private string categoryName;

        public static ScreenManager Instance 
        {
            get
            {
                return _instance;   
            }
        }
        public void setLastLevel(string level)
        {
            lastLevel = "";
            lastLevel = level;
        }

        public string getLastLevel()
        {
            return lastLevel;
        }

        public void BackToPreviousLevel()
        {
            //Application.LoadLevel(getLastLevel());
            SceneManager.LoadScene(SceneManager.GetSceneByName(lastLevel).buildIndex, LoadSceneMode.Single);
        }
        //Awake is always called before any Start functions
        void Awake()
        {
            //Check if instance already exists
            if (_instance == null)
                
                //if not, set instance to this
                _instance = this;
            
            //If instance already exists and it's not this:
            else if (_instance != this)
                
                //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
                Destroy(gameObject);    
            
            //Sets this to not be destroyed when reloading scene
            DontDestroyOnLoad(gameObject);
            
                      
            //Call the InitGame function to initialize the first level 
           InitGame();
        }
        
        //Initializes the game for each level.
        void InitGame()
        {
            _parameters = new AppScreenParameters();            
        }
        public void navigateToCategory(Category category)
        {
            this.categoryName = category.Name;
            this.CategoryId = category.ID;
            //Application.LoadLevel(1);
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
        public void navigateToLevel(int level, LoadSceneMode mode)
        {            
            //Application.LoadLevel(1);
            
            SceneManager.LoadScene(level, mode);
        }
        public void backToPreviousScreen()
        {
            Application.LoadLevel(lastLevel);
            //Application.LoadLevel(0);
        }
        public string getCategoryName()
        {
            return this.categoryName;
        }
        public int getCategoryID()
        {
            return this.CategoryId;
        }
        public void LoadImage(string imagePath)
        {
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
        }

        public void ShowMenu()
        {
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
        }

        //Update is called every frame.
        void Update()
        {
            
        }
}