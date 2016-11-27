using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Assets.Scripts.Classes;
using Assets.Classes;       //Allows us to use Lists. 

      
public class ScreenManager : MonoBehaviour
{

        public static ScreenManager instance = null;              //Static instance of ScreeManager which allows it to be accessed by any other script.
        public AppScreenParameters _parameters;
                                      
        private static string lastLevel;
        private int CategoryId;
        private string categoryName;

        public static void setLastLevel(string level)
        {
            lastLevel = level;
        }

        public static string LastLevel()
        {
            return lastLevel;
        }

        public static void BackToPreviousLevel()
        {
            Application.LoadLevel(lastLevel);
        }
        //Awake is always called before any Start functions
        void Awake()
        {
            //Check if instance already exists
            if (instance == null)
                
                //if not, set instance to this
                instance = this;
            
            //If instance already exists and it's not this:
            else if (instance != this)
                
                //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
                Destroy(gameObject);    
            
            //Sets this to not be destroyed when reloading scene
            DontDestroyOnLoad(gameObject);
            
                      
            //Call the InitGame function to initialize the first level 
           // InitGame();
        }
        
        //Initializes the game for each level.
        /*void InitGame()
        {
                        
        }*/
        public void navigateToCategory(Category category)
        {
            this.categoryName = category.Name;
            this.CategoryId = category.ID;
            //Application.LoadLevel(1);
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
        public void navigateToLevel(int level, LoadSceneMode mode)
        {            
            //Application.LoadLevel(1);
            
            SceneManager.LoadScene(level, mode);
        }
        public void backToPreviousScreen()
        {
            //Application.LoadLevel(lastLevel);
            Application.LoadLevel(0);
        }
        public string getCategoryName()
        {
            return this.categoryName;
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