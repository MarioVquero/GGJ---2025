using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementScript : MonoBehaviour
{

    public Vector3 moveDirection;
    public Transform transform;
    public Rigidbody RB;
    public float speed = 5;
    // canMove is false for intro to game 
    public bool canMove;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        lockPlayer();
        RB = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {

        if (canMove == true)
        {
            Debug.Log(canMove);
            movement();
        }
    }

    // seperate this part in case I need to stop movement
    public void movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector3(x, 0, z);
        transform.Translate(moveDirection * Time.deltaTime * speed);
    }


    public void lockPlayer()
    {
        canMove = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void unlockPlayer()
    {
        canMove = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
