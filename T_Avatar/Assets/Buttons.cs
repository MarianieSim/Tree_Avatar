using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button Back, BuyWater, BuyFerti, waterBackButton, feriBackButton, MoneyBackButton;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        Back.onClick.AddListener(TaskOnClick);
        waterBackButton.onClick.AddListener(WTaskOnClick);
        feriBackButton.onClick.AddListener(FTaskOnClick);
        MoneyBackButton.onClick.AddListener(MTaskOnClick);
        BuyWater.onClick.AddListener(delegate { TaskWithParameters("Hello"); });
        BuyFerti.onClick.AddListener(() => ButtonClicked(42));
    }

    void TaskOnClick()
    {
        //Back
        Debug.Log("You have clicked the button!");
        popup.close();
    }
    void WTaskOnClick()
    {
        waterPopup.close();
    }

    void FTaskOnClick()
    {
        //Back
       
        FertPopup.close();
    }
    void MTaskOnClick()
    {
        //Back

        MoneyPopup.close();
    }


    void TaskWithParameters(string message)
    {
        //Water

        if (Bucks.text - 5 > -1)
        {
            Bucks.text = Bucks.text - 5;
            Wcount.text++;
        }
        else
        {
            popup.close();
            MoneyPopup.open();
        }
      
    }

    void ButtonClicked(int buttonNo)
    {
        //Fertilizer
        if(Bucks.text-20 > -1)
        {
            Bucks.text = Bucks.text - 20;
            Fcount.text++;
        }
        else
        {
            popup.close();
            MoneyPopup.open();
        }

    }
}