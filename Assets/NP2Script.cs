using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NP2Script : MonoBehaviour
{

    public playerMovementScript PMScript;
    public int primeInt = 1;

    public int stressmeter =0;

    public bool allowspace = false;


    public TMP_Text NPCText;
    public TMP_Text PlayerText;

    public GameObject PlayerDisplay;
    public GameObject NPCDisplay;


    public GameObject NPC1ChoiceA;
    public GameObject NPC1ChoiceB;


    public GameObject GoodChoice2;
    public GameObject GoodChoice3;


    public GameObject Badchoice2;
    
    public GameObject Badchoice3;
    
    public GameObject Badchoice4;
    
    public GameObject Badchoice5;


    // Start is called before the first frame update
    void Start()
    {
        PlayerDisplay.SetActive(false);
        NPCDisplay.SetActive(false);

        NPC1ChoiceA.SetActive(false);
        NPC1ChoiceB.SetActive(false);

        // GoodChoice2.SetActive(false);
        // GoodChoice3.SetActive(false);
        

        // Badchoice2.SetActive(false);
        // Badchoice3.SetActive(false);
        // Badchoice4.SetActive(false);

        // Badchoice5.SetActive(false);

        NPCText.text = "";
        PlayerText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(allowspace == true && Input.GetKeyDown(KeyCode.Space))
        {
            PMScript.lockPlayer();
            Next();
        }
    }

    public void Next()
    {
        primeInt += 1;

        if(primeInt == 2)
        {
            PlayerDisplay.SetActive(true);
            PlayerText.text = "Excuse me? Anyone home?";
        }
        if(primeInt == 3)
        {
            PlayerText.text = "I won't be staying here too long.";
        }
        if(primeInt == 4)
        {
            PlayerText.text = "My name is “MC’s Name, I’m the detective assigned to work on your case.";
        }
        if(primeInt == 5)
        {
            PlayerText.text = "Hello?";
        }
        if(primeInt == 6)
        {
            PlayerDisplay.SetActive(false);
            NPCDisplay.SetActive(false);
            PlayerText.text = "Who the hell are you?";

            NPC1ChoiceA.SetActive(true);
            NPC1ChoiceB.SetActive(true);
        }
    }
}
