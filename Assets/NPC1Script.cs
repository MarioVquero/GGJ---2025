using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NPC1Script : MonoBehaviour
{

    public int primeInt = 1;

    public bool allowspace = true;
    

    public bool ActivateChoice1 = false;
    public bool ActivateChoice2 = false;


    // TextBox for the NPC (might not need) and box for the Text 
    public TMP_Text NPCName;
    public TMP_Text NPCText;

    // Text for the Player Script and name
    public TMP_Text PlayerName;
    public TMP_Text PlayerText;

    // where we actually display the text in NPCText
    public GameObject PlayerTextDisplay;
    public GameObject NPCTextDisplay;


    // choices the player will have (limited to 2-3 for scope) 
    public GameObject NPC1ChoiceA;
    public GameObject NPC1ChoiceB;

    // button to skip text/move on to the next line 
    public GameObject nextButton;



    // Start is called before the first frame update
    void Start()
    {
        PlayerTextDisplay.SetActive(false);
        NPCTextDisplay.SetActive(false);


        NPC1ChoiceA.SetActive(false);
        NPC1ChoiceB.SetActive(false);
        nextButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (allowspace)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Next();
            }
        }
    }

    public void Next()
    {
        primeInt += 1;

        if (primeInt == 2)
        {
            Debug.Log(primeInt);
            PlayerTextDisplay.SetActive(true);
            NPCTextDisplay.SetActive(true);
            NPCName.text = "";
            NPCText.text = "";
            PlayerName.text = "";
            PlayerText.text = "";
            
        }
        else if (primeInt == 3)
        {
            Debug.Log(primeInt);
            NPCName.text = "";
            NPCText.text = "";
            PlayerName.text = "";
            PlayerText.text = "";

            Cursor.lockState = CursorLockMode.Confined;

            NPC1ChoiceA.SetActive(true);
            NPC1ChoiceB.SetActive(true);
        }

        else if(primeInt == 4 && ActivateChoice1)
        {
            Debug.Log(primeInt + "" + ActivateChoice1);
            NPCName.text = "";
            NPCText.text = "";
            PlayerName.text = "";
            PlayerText.text = "";
        }else if(primeInt == 4 && ActivateChoice2)
        {
            Debug.Log(primeInt + "" + ActivateChoice2);
            NPCName.text = "";
            NPCText.text = "";
            PlayerName.text = "";
            PlayerText.text = "";
        }
    }


    public void Choice1Results()
    {
        Cursor.lockState = CursorLockMode.Locked;
        NPC1ChoiceA.SetActive(false);
        NPC1ChoiceB.SetActive(false);
        ActivateChoice1 = true;
        Next();
    }

    public void Choice2Results()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        NPC1ChoiceA.SetActive(false);
        NPC1ChoiceB.SetActive(false);
        ActivateChoice2 = true;
        Next();
    }


}
