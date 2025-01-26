using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCanvasScript : MonoBehaviour
{

    public GameObject StartScreen;
    public GameObject TutorialScreen;

    public playerMovementScript PMScript;

    public GameObject StartButton;

    // Start is called before the first frame update
    void Start()
    {
        StartScreen.SetActive(true);
        StartButton.SetActive(true);

        TutorialScreen.SetActive(false);

        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ContinueButtonAction();
        }
    }


    public void StartButtonAction()
    {
        StartScreen.SetActive(false);
        StartButton.SetActive(false);

        TutorialScreen.SetActive(true);
    }
    public void ContinueButtonAction()
    {
        PMScript.unlockPlayer();
        TutorialScreen.SetActive(false);
        // Set bools for movement and camera to true as they spawn as false by default
    }
}
