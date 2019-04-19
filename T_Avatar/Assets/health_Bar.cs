using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_Bar : MonoBehaviour {

    public double max = 0;
    public float maxGrowth = 0.5f;
    public float speedGrowth = 0.1f;
    public float moveX = -0.5f;
    Vector3 tempScale;
    Vector3 tempP;
    public static int c = 1;
  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GrowTree.count == c)
        {
            tempScale = transform.localScale;
            tempP = transform.localPosition;
            if (transform.localScale.x < maxGrowth)
            {

                tempP.x += 0.5f;
                transform.localPosition = tempP;
                tempScale.x += speedGrowth;
                transform.localScale = tempScale;

            }
            c++;
        }

        if (GrowTree.count == 6)
        {
            GrowTree.count = 0;
            c = 1;

            tempScale = transform.localScale;
            tempP = transform.localPosition;


                tempP.x = -0.5f;
                transform.localPosition = tempP;
                tempScale.x = 0;
                transform.localScale = tempScale;

        }


	}

    public static void health()
    {
        print("HI");
    }
}
