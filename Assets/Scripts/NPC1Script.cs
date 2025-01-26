using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NPC1Script : MonoBehaviour
{
    public playerMovementScript pmScript;

    public int primeInt = 1;

    public int stressmeter = 0;

    public bool allowspace = false;
    

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
        Debug.Log(allowspace);
        if (allowspace == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                pmScript.lockPlayer();
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
            // PlayerTextDisplay.SetActive(true);
            NPCTextDisplay.SetActive(true);
            NPCText.text = " Can I help you, sir?";
            PlayerText.text = "";
            
        }
        else if (primeInt == 3)
        {
            PlayerTextDisplay.SetActive(true);
            NPCTextDisplay.SetActive(false);
            Debug.Log(primeInt);
            NPCText.text = "Hello";
            PlayerText.text = "Hi, really sorry to bother you this evening,I won't be staying here too long.My name is MC’s Name, I’m the detective assigned to work on your case. ";


        }

        else if(primeInt == 4 && stressmeter < 75)
        {
            PlayerTextDisplay.SetActive(false);
            NPCTextDisplay.SetActive(true);

            NPCText.text = "Is she alright? Please tell me she is alright it's already been a couple days, she hasn’t answered my calls, I reported the moment she was gone and now I’m starting to---- ";
            PlayerText.text = "";


            NPC1ChoiceA.SetActive(true);
            NPC1ChoiceB.SetActive(true);
        }



        // GOOD CHOICE ROUTE/TEXT
        // // // // // // // // // // // // // // // // // // // // // // // 


        else if(primeInt == 5 && stressmeter < 75)
        {
            PlayerTextDisplay.SetActive(true);
            NPCTextDisplay.SetActive(false);

            NPC1ChoiceA.SetActive(false);


            NPCText.text = "";
            PlayerText.text = "I have reason to believe your daughter is not in any imminent danger, we are on track to retrieve your daughter matter of fact.";
        }

        else if(primeInt == 6 && stressmeter < 75)
        {
            PlayerTextDisplay.SetActive(false);
            NPCTextDisplay.SetActive(true);

            NPCText.text = "";
            PlayerText.text = "Really!?";

            GoodChoice2.SetActive(true);
            
        }
        else if(primeInt == 7 && stressmeter < 75)
        {
            PlayerTextDisplay.SetActive(true);
            NPCTextDisplay.SetActive(false);

            NPCText.text = "";
            PlayerText.text = "Yes, and to do that I’m going to ask you some questions regarding the case all round.";

            GoodChoice2.SetActive(false);
        }

        else if (primeInt == 8 && stressmeter <75) {
            PlayerTextDisplay.SetActive(false);
            NPCTextDisplay.SetActive(true);

            NPCText.text = "Okay.";
            PlayerText.text = "";
            
            GoodChoice3.SetActive(true);
        }
        else if(primeInt == 9 && stressmeter < 75){
            
            NPCText.text = "Thank you detective. You starting to make me feel a lot better, now that I have a grasp. But I don’t need to state the obvious, do what it takes to bring my kid back. ";
            PlayerText.text = "";
            
            GoodChoice3.SetActive(false);

        }
        else if(primeInt == 10 && stressmeter < 75){
            PlayerTextDisplay.SetActive(true);
            NPCTextDisplay.SetActive(false);

            NPCText.text = "";
            PlayerText.text = "I will ma’am. You have my word. ";

            primeInt += 10;
        }

        else if(primeInt >= 11){
            PlayerTextDisplay.SetActive(false);
            PlayerText.text = "";

            NPCTextDisplay.SetActive(false);
            PlayerText.text += "";

            pmScript.unlockPlayer();
        }


        // // BAD CHOICE ROUTE/TEXT
        // // // // // // // // // // // // // // // // // // // // // // // // 

        else if(primeInt == 5 && stressmeter > 25)
        {
            PlayerTextDisplay.SetActive(true);
            NPCTextDisplay.SetActive(false);


            NPCText.text = "";
            PlayerText.text = "I’m going to ask you some questions first, this will help further our investigation.";
        }

        else if(primeInt == 6 && stressmeter >25) {
            PlayerTextDisplay.SetActive(false);
            NPCTextDisplay.SetActive(true);

            Badchoice2.SetActive(true);
            Badchoice3.SetActive(true);

            NPCText.text = "But you didn’t ANSWER my question, please I need someone to tell me that my child is SAFE.";
            PlayerText.text = "";

        }

        else if(primeInt == 7 && stressmeter > 50) {
            PlayerTextDisplay.SetActive(true);
            NPCTextDisplay.SetActive(false);

            NPCText.text = "";
            PlayerText.text = "Ma’am calm down! You are not thinking clearly!";
        }

        else if (primeInt == 8 && stressmeter > 50) {
            PlayerTextDisplay.SetActive(false);
            NPCTextDisplay.SetActive(true);

            Badchoice3.SetActive(true);
            Badchoice4.SetActive(true);

            NPCText.text = "I just want my family back and you are not helping me at all, you come in here demanding shit, and not helping anyone at all.";
            PlayerText.text = "";

        }
        else if (primeInt == 9 && stressmeter > 75) {
            primeInt += 20;
            PlayerTextDisplay.SetActive(false);
            NPCTextDisplay.SetActive(true);
            NPCText.text = "";
            PlayerText.text = "Sigh, I’m leaving, I’m leaving";

        }



        // else if(primeInt == 4 && stressmeter < 27)
        // {
            
        //     NPCText.text = "Really!?";
        //     PlayerText.text = "";
        //     GoodChoice2.SetActive(true);

        // }

        // else if(primeInt == 5 && stressmeter < 27 )
        // {
            
        //     NPCText.text = "Okay.";
        //     PlayerText.text = "";
        //     GoodChoice3.SetActive(true);
        // }
        

        // else if(primeInt == 6 && stressmeter < 54)
        // {
            
        //     NPCText.text = "Thank you detective. You starting to make me feel a lot better, now that I have a grasp. But I don’t need to state the obvious, do what it takes to bring my kid back. ";
        //     PlayerText.text = "";
        // }
        
        
        // // BAD CHOICE ROUTE/TEXT
        // // // // // // // // // // // // // // // // // // // // // // // // 
        
        // else if(primeInt == 4 && stressmeter == 27)
        // {
        //     Debug.Log(primeInt + "" + ActivateChoice2);
            
        //     NPCText.text = "";
        //     PlayerText.text = "";
        // }

        // else if (primeInt == 5 && stressmeter == 54)
        // {
            
        //     NPCText.text = "";
        //     PlayerText.text = "";
        // }

        // else if(primeInt == 6 && stressmeter > 75)
        // {
        //     // game end with bad ending
            
        //     NPCText.text = "";
        //     PlayerText.text = "";
        // }

        
        // // TEXT AFTER SUCCESS
        // // // // // // // // // // // // // // // // // // // // // // // // 

        // else if(primeInt == 7 && stressmeter < 75)
        // {
        //     NPCText.text = "";
        //     PlayerText.text = "";
        // }
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
