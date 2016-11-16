using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;       //Allows us to use Lists. 

      
public class ScreenManager : MonoBehaviour
{

        public static ScreenManager instance = null;              //Static instance of ScreeManager which allows it to be accessed by any other script.
        private int level = 1;                                  //Current level number, expressed in game as "Day 1".
        private int CategoryId;
        private string categoryName;
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
            InitGame();
        }
        
        //Initializes the game for each level.
        void InitGame()
        {
                        
        }
        public void navigateTo(string category)
        {
            this.categoryName = category;
            //Application.LoadLevel(1);
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
        public void backToPreviousScreen()
        {
            Application.LoadLevel(0);
        }
        public string getCategoryName()
        {
            return this.categoryName;
        }
        
        //Update is called every frame.
        void Update()
        {
            
        }
}