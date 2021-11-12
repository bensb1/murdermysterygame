using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject option1;
    public GameObject option2;

     void Start()
    {
        StartCoroutine(Type());
    }
    IEnumerator Type()
    {
        //   yield return new WaitForSeconds(2f);
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }
    }
        void Update()
        {
         /*   if (textDisplay.text == sentences[index])
            {
                continueButton.SetActive(true);
            } */
         }
    public void option1forbutton()
    {
        index = 0;
    }
    public void option2forbutton()
    {
        
        index = 1;
        textDisplay.text = "";
        StartCoroutine(Type());




    }


    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length -1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        } 
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }
}
