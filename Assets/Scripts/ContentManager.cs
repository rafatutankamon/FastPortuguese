using Assets.Scripts.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class ContentManager : MonoBehaviour
    {
        public static ContentManager instance = null;  
        private List<Category> _categories;
        private List<Item> _favorities;

        public List<Category> CategoryList { get { return _categories; } }
        public List<Item> Favorities { get { return _favorities; } }
        void Awake()
        {
            _categories = new List<Category>();
            _favorities = new List<Item>();
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
            initialize();   
        }

        private void initialize()
        {
           
        }

        private void AddFavorite(Item item)
        {
            _favorities.Add(item);
        }

        
        public void RemoveFavorite(Item item)
        {
            _favorities.Remove(item);
        }

        public void OrderByType() 
        {

        }
        public void OrderByDificulty()
        {

        }
    }


}
