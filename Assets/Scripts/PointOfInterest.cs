using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PointOfInterest : MonoBehaviour
{
    public bool isInteractable;
    public KeyCode interactKey=KeyCode.E;


    public GameEvent EnterPOI;
    public GameEvent ExitPOI;
    public GameEvent InteractWithPOI;

   
    public StringVariable PromptText;
    public StringVariable Container;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UpdateTextContainer();
            EnterPOI.Raise();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(interactKey)&&isInteractable)
            {
                InteractWithPOI.Raise();
            }

        }
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            ExitPOI.Raise();


        }
       
    }


    private void UpdateTextContainer()
    {
        if(isInteractable){
            Container.Value = PromptText.Value + " [" + interactKey+"]";
        }
        else
        {
            Container.Value = PromptText.Value;
        }
    }



}
