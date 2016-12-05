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
