﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bucks : MonoBehaviour {
    public Text TextPro;
    public static int text;
	// Use this for initialization
	void Start () {
        text = 100;
     
	}
	
	// Update is called once per frame
	void Update () {

        TextPro.text = "$" + text.ToString();


    }

 
}
