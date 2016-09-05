using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Initializer : MonoBehaviour {
    //private 
  

    //public
    public GameObject listItemPrefab;
    public GameObject categoryItemPrefab;
    public GameObject grid_Itens;
    public GameObject grid_Categories;
	void Start () 
    {
       StartCoroutine(Fullscreen(true));
       //var gd = content.GetComponent<RectTransform>();
       //var cs = content.GetComponent<ContentSizeFitter>();
       //Debug.LogWarning("initial height " + gd.rect.height);
      
       if (grid_Itens != null && grid_Categories !=null)
        {
            if (listItemPrefab != null && categoryItemPrefab != null)
            {    
               CreateCategoryItens();
               CreateCategories();
            }
            //Debug.LogWarning("final height " + gd.rect.height);
           // gd.localPosition.Set(gd.localPosition.x, (float)gd.rect.height / 2f, 0);
        }
	
	}
	
    void CreateCategoryItens(string optionalCategory = "favoritos")
    {
         
                //rt.sizeDelta = new Vector2(0, 20 * 120);
                for (int x = 0; x < 20; x++)
                {
                    //inatancia o objeto da lista
                    GameObject go = Instantiate(listItemPrefab, new Vector3(x, x, 0), Quaternion.identity) as GameObject;

                    //go.transform.position = new Vector3(0, x * 120, 0);
                    go.transform.SetParent(grid_Itens.transform);
                    //go.GetComponent<RectTransform>().localScale = Vector3.one;
                    //rt.sizeDelta=new Vector2(rt.sizeDelta.x,x*120);
                }
                //scrollrt.Rebuild(CanvasUpdate.LatePreRender);
    }
    void CreateCategories()
    {        
        for (int x = 0; x < 20; x++)
        {
            //inatancia o objeto da lista
            GameObject go = Instantiate(categoryItemPrefab, new Vector3(x, x, 0), Quaternion.identity) as GameObject;

            //go.transform.position = new Vector3(0, x * 120, 0);
            go.transform.SetParent(grid_Categories.transform);
            //go.GetComponent<RectTransform>().localScale = Vector3.one;
            //rt.sizeDelta=new Vector2(rt.sizeDelta.x,x*120);
        }
        //scrollrt.Rebuild(CanvasUpdate.LatePreRender);
    }

    private IEnumerator Fullscreen(bool fullscreen)
    {
        int width = Mathf.FloorToInt(720); //Player pref resolution
        int height = Mathf.FloorToInt(1280);
        Screen.fullScreen = fullscreen;

        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();
        
        Screen.SetResolution(width, height, Screen.fullScreen);
    }
    private void ScaleAdjust()
    {

    }
}
