using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowTree : MonoBehaviour {

    public float maxGrowth = 1;
    public float speedGrowth = 0.1f;
    Vector3 tempScale;
    public Tree TestTreeObject;
    public static int count = 0;

    private bool hideObject;
    // Use this for initialization
    //GameObject go = GameObject.Find("Inside bar");

    void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hideObject)
        {
            if (other.gameObject.name == "can" || other.gameObject.name == "fert")
            {
                if(count == 5)
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

                count++;
            }


        }
    }
 

    // Update is called once per frame
    void Update()
    {

        if (count == 5)
        {
            tempScale = transform.localScale;
            if (transform.localScale.x < maxGrowth)
            {
                tempScale.x += speedGrowth;
                tempScale.y += speedGrowth * 2;
                tempScale.z += speedGrowth;
                transform.localScale = tempScale;
            }
            count++;
        }

      
    }
}
