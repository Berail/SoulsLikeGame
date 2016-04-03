using UnityEngine;
using System.Collections;

public class InputWrapper  {

    private static readonly InputWrapper instance = new InputWrapper();

    private InputWrapper(){}

    public static InputWrapper getInstance()
    {
       return instance;
    }

    public float getLeftThumbHorizontal()
    {
        return Input.GetAxis("LHorizontalAxis");
    }

    public float getLeftThumbVertical()
    {
        return Input.GetAxis("LVerticalAxis");
    }

    public float getRightThumbHorizontal()
    {
        return Input.GetAxis("RHorizontalAxis");
    }

    public float getRightThumbVertical()
    {
        return Input.GetAxis("RVerticalAxis");
    }

    public float getDPadHorizontal()
    {
        return Input.GetAxis("Left/Right");
    }

    public float getDPadVertical()
    {
        return Input.GetAxis("Up/Down");
    }

    public float getTriggersValue()
    {
        return Input.GetAxis("RT/LT");
    }

    public bool getAButton()
    {
        return Input.GetButton("AButton");
    }

    public bool getBButton()
    {
        return Input.GetButtonDown("BButton");
    }

    public bool getXButton()
    {
        return Input.GetButton("XButton");
    }

    public bool getYButton()
    {
        return Input.GetButton("YButton");
    }

    public bool getRBButton()
    {
        return Input.GetButton("RB");
    }

    public bool getLBButton()
    {
        return Input.GetButton("LB");
    }

    public bool getR3Button()
    {
        return Input.GetButton("R3");
    }

    public bool getL3Button()
    {
        return Input.GetButton("L3");
    }

    public bool getStartButton()
    {
        return Input.GetButton("Start");
    }

    public bool getBackButton()
    {
        return Input.GetButton("Back");
    }
    
}
