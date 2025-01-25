using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform playerTransform;
    public playerMovementScript playerMovementScript;

    public float mouseSens = 5;
    public float camVertRot = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovementScript.canMove)
        {
            cameraMove();    
        }
        
    }

    public void cameraMove()
    {
        float inputX = Input.GetAxis("Mouse X") * mouseSens;
        float inputY = Input.GetAxis("Mouse Y")  * mouseSens;

        camVertRot -= inputY;
        camVertRot = Mathf.Clamp(camVertRot, -90f, 90);
        transform.localEulerAngles = Vector3.right * camVertRot;


        playerTransform.Rotate(Vector3.up * inputX);
    }
}
