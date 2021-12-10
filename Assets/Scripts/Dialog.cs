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
   
    public AudioSource speechSoundEffect;

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
        speechSoundEffect.Play();




    }
    public void option3forbutton()
    {


        index = 2;
        textDisplay.text = "";
        StartCoroutine(Type());
        speechSoundEffect.Play();




    }
    public void option4forbutton()
    {

        index = 3;
        textDisplay.text = "";
        StartCoroutine(Type());
        speechSoundEffect.Play();




    }
    public void option5forbutton()
    {

        index = 4;
        textDisplay.text = "";
        StartCoroutine(Type());
        speechSoundEffect.Play();




    }
    public void option6forbutton()
    {

        index = 5;
        textDisplay.text = "";
        StartCoroutine(Type());
        speechSoundEffect.Play();




    }
    public void option7forbutton()
    {

        index = 6;
        textDisplay.text = "";
        StartCoroutine(Type());
        speechSoundEffect.Play();




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
