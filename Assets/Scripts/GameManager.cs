using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int currentStep;
    [SerializeField] Button startButton;
    [SerializeField] List<string> instructions = new List<string>();
    [SerializeField] TextMeshProUGUI stepsText;


    void Start()
    {
        // the list that apears on the screen to show the user the steps 
        instructions.Add("<color=#ff0000><size=3><b>Flame Test</b></size></color>\nLaboratory\nThis test used to detect the material from the color \r\n apeared from the burned material");
        instructions.Add("use the grab button to grab the material.");
        instructions.Add( "put the material in the flame and notice the output color\nThe flame color detect the burned material");
        instructions.Add( "you burned Cupper (Cu) \n and get falme colored <color=#ff0000>Red</color>. \n\n let's Try another matarial ");
        instructions.Add( "you burned Barium (Ba) \n and get flame colored <color=#00ff00>Green</color>. \n\n let's Try another matarial");
        instructions.Add( "you burned Sodium (Na) \n and get flame colored <color=#ff7f00>Orange</color>. \n\n let's Try another matarial");
        instructions.Add( "you burned caesium (cs)\n and get flame colored<color=#9c98cf> Purple</color>. \n\n let's Try another matarial");
        
        // set the first item on the list to be showed when game starts
        currentStep = 0;
    }

    private void Update()
    {
        // use current step  number to show the list item on the screen 
        stepsText.text =  instructions[currentStep];
       // stepsText.text.fontstyle.bold;
    }


    public void SetCurrentStep(int stepNo)
    {
        currentStep = stepNo;
    }

    public void StartTheGame()
    {
        SetCurrentStep(1);
        startButton.gameObject.SetActive(false );
        

    }

    public void grabMaterial()
    {
        SetCurrentStep(2);
    }

}
