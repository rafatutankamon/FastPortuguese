using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItensManager : MonoBehaviour {

    public Text categoryName;

	// Use this for initialization
	void Start () {
       categoryName.text = ScreenManager.instance.getCategoryName();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
