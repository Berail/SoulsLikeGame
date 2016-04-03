using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    InputWrapper input = InputWrapper.getInstance();

    public Transform cameraTransform;
    public Transform playerTransform;

    Vector3 playerStartingPosition;
    public float maxDistance;

	// Use this for initialization
	void Start () {
        playerStartingPosition = playerTransform.position;
    }
	
	// Update is called once per frame
	void Update () {
	    if(input.getRightThumbHorizontal() != 0 || input.getRightThumbHorizontal() != 0)
        {
            if(Mathf.Abs(playerStartingPosition.x - cameraTransform.transform.position.x) <= maxDistance)
            {
                cameraTransform.transform.position += Vector3.right * input.getRightThumbHorizontal() * Time.deltaTime;
            }

            if (Mathf.Abs(playerStartingPosition.y - cameraTransform.transform.position.y) <= maxDistance)
            {
                cameraTransform.transform.position += Vector3.up * input.getRightThumbVertical() * Time.deltaTime;
            }
        }
        else
        {
            if(Mathf.Abs(playerStartingPosition.x - cameraTransform.transform.position.x) != 0)
            {
                if(Mathf.Sign(playerStartingPosition.x - cameraTransform.transform.position.x) > 0)
                {
                    cameraTransform.transform.position += Vector3.right*Time.deltaTime;
                }
                else
                {
                    cameraTransform.transform.position -= Vector3.right * Time.deltaTime;
                }
            }

            if (Mathf.Abs(playerStartingPosition.y - cameraTransform.transform.position.y) != 0)
            {
                if (Mathf.Sign(playerStartingPosition.y - cameraTransform.transform.position.y) > 0)
                {
                    cameraTransform.transform.position += Vector3.up * Time.deltaTime;
                }
                else
                {
                    cameraTransform.transform.position -= Vector3.up * Time.deltaTime;
                }
            }
        }
	}
}
