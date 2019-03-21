using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaves : MonoBehaviour {

    public float maxGrowth = 1;
    public float speedGrowth = 0.0001f;
    Vector3 tempScale;
    public Tree TestTreeObject;
    public GameObject targetObject;

    private bool hideObject;
    // Use this for initialization

    void Start()
    {
        targetObject.SetActive(false);
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
      
        yield return new WaitForSecondsRealtime(20);
        targetObject.SetActive(true);
    }




    // Update is called once per frame
    void Update()
    {

        tempScale = transform.localScale;
        if (transform.localScale.x < maxGrowth)
        {
            tempScale.x += speedGrowth;
            tempScale.y += speedGrowth * 2;
            tempScale.z += speedGrowth;
            transform.localScale = tempScale;
        }


      
    }
}
