using Assets.Scripts.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    class SplashBehaviour : MonoBehaviour
    {

        void Awake()
        {


        }
        void Start()
        {
            ShowLoading();
            TryLoadJSON();
        }
        void TryLoadJSON()
        {
            if(true)
            {
                SaveBackupJSON();
                CreateCategories();
            }
        }
        void SaveBackupJSON()
        {

        }
        void RestoreBackupJSON()
        {
            TryLoadJSON();
        }
        public void CreateCategories()
        {
            var c = Category.CreateFromJSON("json");
            CreateCategoryItens(c.ID);
            HideLoading();
        }
        public void CreateCategoryItens(int categoryID)
        {

        }

        public void ShowError()
        {

        }
        public void ShowLoading()
        {

        }
        public void HideLoading()
        {
            FinishSplash();
        }
        void FinishSplash()
        {
            ScreenManager.instance.setLastLevel(Application.loadedLevelName);
            ScreenManager.instance.navigateToLevel(1, LoadSceneMode.Single);
            //call sreenmanger to change level
        }
    }
}
