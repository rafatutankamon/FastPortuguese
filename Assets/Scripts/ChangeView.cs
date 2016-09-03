using UnityEngine;
using System.Collections;

public class ChangeView : MonoBehaviour {

    public GameObject container;
	// Use this for initialization

    private Vector3 _initialPosition;
	void Start () {
        _initialPosition = container.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void BtnClick()
    {
        container.transform.position = Vector3.Lerp(container.transform.position, new Vector3(container.transform.position.x - 372f, container.transform.position.y, 0), 3f * Time.fixedTime); 
    }
    public void RestartPosition()
    {
       container.transform.position = _initialPosition;
    }
}
