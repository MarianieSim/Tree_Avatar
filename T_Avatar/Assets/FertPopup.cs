using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FertPopup : MonoBehaviour {

    public static GameObject targetObject;
    // Use this for initialization
    void Start()
    {
        targetObject = this.gameObject;
        targetObject.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {


    }

    public static void open()
    {
        
        targetObject.SetActive(true);

    }

    public static void close()
    {
      
        targetObject.SetActive(false);

    }
}


