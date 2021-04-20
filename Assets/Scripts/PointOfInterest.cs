using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointOfInterest : MonoBehaviour
{
    public bool hasPrompt=true;
    public KeyCode interactKey=KeyCode.E;


    public GameEvent EnterPOI;
    public GameEvent ExitPOI;
    public GameEvent InteractWithPOI;

   
    public StringVariable PromptText;
    public StringVariable POIPromptText;
    public Location location;
    public Location currentLocation;
    private bool playerInPOI = false;

    private void Update()
    {
        if (playerInPOI)
        {
            if (Input.GetKeyDown(interactKey) && hasPrompt)
            {
               
                InteractWithPOI.Raise();
               
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UpdateLocation();
            playerInPOI = true;
         
            UpdateTextContainer();
            EnterPOI.Raise();
        }
    }
 



    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            playerInPOI = false;
            ExitPOI.Raise();


        }
       
    }


    private void UpdateTextContainer()
    {
        if(hasPrompt){
            POIPromptText.Value = location.LocationName + " [" + interactKey+"]";
        }
        else
        {
            POIPromptText.Value = PromptText.Value;
        }
    }

    private void UpdateLocation()
    {
        currentLocation.LocationName=location.LocationName;
        currentLocation.LocationDescription = location.LocationDescription;
        currentLocation.LocationSprite = location.LocationSprite;
    }
   

}
