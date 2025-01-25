using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NPC1Script : MonoBehaviour
{

    public int primeInt = 1;

    public int stressmeter = 0;

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


    public GameObject GoodChoice2;
    public GameObject GoodChoice3;


    public GameObject Badchoice2;
    
    public GameObject Badchoice3;
    
    public GameObject Badchoice4;
    
    public GameObject Badchoice5;


    // button to skip text/move on to the next line 
    public GameObject nextButton;



    // Start is called before the first frame update
    void Start()
    {
        Badchoice2.SetActive(false);
        Badchoice3.SetActive(false);
        Badchoice4.SetActive(false);
        Badchoice5.SetActive(false);
        
        GoodChoice2.SetActive(false);
        GoodChoice3.SetActive(false);

        PlayerTextDisplay.SetActive(false);
        NPCTextDisplay.SetActive(false);


        NPC1ChoiceA.SetActive(false);
        NPC1ChoiceB.SetActive(false);

        NPCText.text = "";
        PlayerText.text = "";



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
            NPCText.text = "Hello";
            PlayerText.text = "";
            
        }
        else if (primeInt == 3)
        {
            PlayerTextDisplay.SetActive(false);
            Debug.Log(primeInt);
            NPCText.text = "Hello";
            PlayerText.text = "";

            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;

            NPC1ChoiceA.SetActive(true);
            NPC1ChoiceB.SetActive(true);
        }
        // GOOD CHOICE ROUTE/TEXT
        // // // // // // // // // // // // // // // // // // // // // // // 

        else if(primeInt == 4 && stressmeter < 27)
        {
            
            NPCText.text = "";
            PlayerText.text = "";
            GoodChoice2.SetActive(true);

        }

        else if(primeInt == 5 && stressmeter < 27 )
        {
            
            NPCText.text = "";
            PlayerText.text = "";
            GoodChoice3.SetActive(true);
        }
        

        else if(primeInt == 6 && stressmeter < 54)
        {
            
            NPCText.text = "";
            PlayerText.text = "";
        }
        
        
        // BAD CHOICE ROUTE/TEXT
        // // // // // // // // // // // // // // // // // // // // // // // 
        
        else if(primeInt == 4 && stressmeter == 27)
        {
            Debug.Log(primeInt + "" + ActivateChoice2);
            
            NPCText.text = "";
            PlayerText.text = "";
        }

        else if (primeInt == 5 && stressmeter == 54)
        {
            
            NPCText.text = "";
            PlayerText.text = "";
        }

        else if(primeInt == 6 && stressmeter > 75)
        {
            // game end with bad ending
            
            NPCText.text = "";
            PlayerText.text = "";
        }

        
        // TEXT AFTER SUCCESS
        // // // // // // // // // // // // // // // // // // // // // // // 

        else if(primeInt == 7 && stressmeter < 75)
        {
            NPCText.text = "";
            PlayerText.text = "";
        }
    }

    
    public void GoodChoiceResults()
    {
        stressmeter -= 10;
        NPC1ChoiceA.SetActive(false);
        NPC1ChoiceB.SetActive(false);
        ActivateChoice1 = true;
        Next();
    }

    public void GoodChoiceAgain()
    {
        
        stressmeter -= 10;
        GoodChoice2.SetActive(false);
        Next();
    }
    public void FinalGoodChoice()
    {
        stressmeter -= 10;
        GoodChoice3.SetActive(false);
        Next();
    }




    public void BadChoiceResults()
    {
        Badchoice2.SetActive(true);
        Badchoice3.SetActive(true);
        ActivateChoice2 = true;
        stressmeter += 27;
        Next();
    }

    public void BadChoiceAgain()
    {
        Badchoice4.SetActive(true);
        Badchoice5.SetActive(true);
        stressmeter += 27;
        Next();
    }

    public void finalBadChoice()
    {
        stressmeter += 27;
        if (stressmeter >= 75)
        {
            Debug.Log("end game");
        }
        Debug.Log("lost after this");
    }


}
