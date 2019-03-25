using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour {

    float distance = 10;

    public void OnMouseDrag()
    {
        
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objpostion = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objpostion;
    
       
	}

	private void OnMouseUp()
	{
        transform.position = new Vector3((float)-1.9225, (float)0.84155, (float)-4.64);
	}

	

}
