using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts.Classes;
using Assets.Scripts.Enum;

public class ItensManager : MonoBehaviour {

    public Text categoryName;
    public GameObject prefabType1;
    public GameObject prefabType2;
    public GameObject prefabType3;

    void Awake()
    {

    }
    // Use this for initialization
    void Start()
    {
        categoryName.text = ScreenManager.instance.getCategoryName();
        ScaleAdjustPrefabs();
        CreateCategoryItens();
    }
    void CreateCategoryItens(Category category)
    {
        foreach(var c in Categories.instance.CategoryList)
        {
            var go = GetPrefabToInstantiate(c.ContentType);
        }
        
    }
    public GameObject GetPrefabToInstantiate(ContentType type)
    {
        switch (type)
            {
                case ContentType.Text:
                    return prefabType1;
                    break;
                case ContentType.Text_Image:
                    return prefabType1;
                    break;
                case ContentType.Text_Image_Sound:
                    return prefabType1;
                    break;        
    }
    public void ScaleAdjustPrefabs()
    {

    }
}
