using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public GameObject PanelDialogue;
    private bool Hidden;
    public TextMeshProUGUI Dialoguetext;
    public float textspeed = 0.1f;
    public string[] lines;
    int index;
    //Interactuable interactuable;
    
  
    void Start()
    {
        PanelDialogue.SetActive(Hidden);
        Dialoguetext.text = string.Empty;
        startdiaogue();
    }

  
    void Update()
    {
        if (Interactuable.Dialogue2 == true &&  Input.GetKeyDown(KeyCode.E))
        {
            PanelDialogue.SetActive(!Hidden);
            Dialoguetext.text = string.Empty;
            startdiaogue();

            if (Input.GetKeyDown(KeyCode.Return))
            {
            if(Dialoguetext.text == lines[index])
            {
                nextline();
            }
            else
            {
                StopAllCoroutines();
                Dialoguetext.text = lines[index];
            }
               
            }   
        }
    }
    public void startdiaogue()
    {
        index = 0;
        StartCoroutine(Writeline());
    }

     IEnumerator Writeline()
     {  
         foreach(char letter in lines[index].ToCharArray())
         {
             Dialoguetext.text += letter;
             yield return new WaitForSeconds(textspeed); 
         }
      
     }
    public void nextline()
    {
        if(index < lines.Length - 1)
        {
            index++;
            Dialoguetext.text = string.Empty;
            StartCoroutine(Writeline());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
  
}
