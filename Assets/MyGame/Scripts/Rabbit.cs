using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum RabbitsColor
{
    red,
    white,
    blue,
    yellow
}

public class Rabbit : MonoBehaviour
{
    [SerializeField] private InputField myAgeInputField;
    private string rabbitName;
    [SerializeField] private RabbitsColor rabbitColor;
    public int rabbitAge;
    private int flowersGathered;
    [SerializeField] Transform myPosMain;
    public bool myTurn = false;
    [SerializeField] private Image bgMyTurnImage;
    

    private Image myImage;

    // Start is called before the first frame update
    void Start()
    {
        myImage = GetComponent<Image>();
        SetRabbitColor();
    }

    public void SetCurrentTurn(bool t)
    {
        myTurn = t;
        bgMyTurnImage.gameObject.SetActive(myTurn);
    }

    public bool AgeIsGiven()
    {
        if(myAgeInputField.textComponent.text != "")
        {
            try
            {
                rabbitAge = int.Parse(myAgeInputField.text);
                return true;
            }
            catch
            {
                return false;
            }
        }
        else
        {
            return false;
        } 
    }

    private void SetColorNoAgeGiven()
    {
        ColorBlock noAgeGiven = ColorBlock.defaultColorBlock;
        noAgeGiven.normalColor = Color.red;
        myAgeInputField.colors = noAgeGiven;
    }
    
    public void SetRabbitMainPos()
    {
        gameObject.transform.position = myPosMain.position;
    }

    private void SetRabbitColor()
    {
        switch(rabbitColor)
        {
            case RabbitsColor.red:
                myImage.color = Color.red;
                break;
            case RabbitsColor.yellow:
                myImage.color = Color.yellow;
                break;
            case RabbitsColor.blue:
                myImage.color = Color.blue;
                break;
            case RabbitsColor.white:
                myImage.color = Color.white;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
