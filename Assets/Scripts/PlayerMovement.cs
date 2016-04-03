using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    InputWrapper Input = InputWrapper.getInstance();
    Vector2 position;
    Vector2 finalPosition;
    Vector2 defaultRollDirection;

    public float walkSpeed;
    public float rollSpeed;
    int rollTimer;
    bool canRoll;

    // Use this for initialization
    void Start () {
        position = (Vector2)transform.position;
        defaultRollDirection = transform.up;
        canRoll = false;
        rollTimer = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.getBButton() && canRoll == false)
        {
            canRoll = true;
        }
        if(canRoll)
        {
            if(rollTimer != 10)
            {
                finalPosition = UpdateRollPosition(position);
                rollTimer++;
            }
            else
            {
                rollTimer = 0;
                canRoll = false;
            }
        }
        else
        {
            finalPosition = UpdatePosition(position);
        }

       
        transform.position += (Vector3)finalPosition;
	}

    Vector2 UpdateRollPosition(Vector2 position)
    {
        if(Input.getLeftThumbHorizontal() != 0 || Input.getLeftThumbVertical() != 0)
        {
            defaultRollDirection = new Vector2(Input.getLeftThumbHorizontal(), Input.getLeftThumbVertical()).normalized;
        }
        position += defaultRollDirection * Time.deltaTime * rollSpeed;
        return position;
    }

    Vector2 UpdatePosition(Vector2  position)
    {
        position += (Vector2)transform.right*Input.getLeftThumbHorizontal() * Time.deltaTime * walkSpeed;
        position += (Vector2)transform.up * Input.getLeftThumbVertical() * Time.deltaTime * walkSpeed;
        if (Input.getLeftThumbHorizontal() != 0 || Input.getLeftThumbVertical() != 0)
        {
            defaultRollDirection = new Vector2(Input.getLeftThumbHorizontal(), Input.getLeftThumbVertical()).normalized;
        }
        return position;
    }
}
