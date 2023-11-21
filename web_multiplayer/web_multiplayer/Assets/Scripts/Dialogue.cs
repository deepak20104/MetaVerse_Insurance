using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Dialogue : MonoBehaviour
{
 
    [SerializeField]
    private TMP_Text dialogueText;
    public GameObject DialoguePanel;
    public GameObject FromOption1;

  

    public int step=0;
       
    [SerializeField]
    [TextArea]
    private string[] dialogueWords;
    



    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Interact"))
        {   
                DialoguePanel.gameObject.SetActive(true);
                dialogueText.text=dialogueWords[step];
                step+=1;
               
        }
    }
    public void closeDialogue()
    {
        DialoguePanel.gameObject.SetActive(false);
        FromOption1.gameObject.SetActive(false);
        
    }
    public void switchPanels()
    {
         DialoguePanel.gameObject.SetActive(false);
         FromOption1.gameObject.SetActive(true);
    }
    public void switchToInsScene()
    {
        SceneManager.LoadScene(sceneName:"InsuranceDetails");

    }


    
}
