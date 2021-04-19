using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryWindowManager : MonoBehaviour
{
    public Button leaveButton;
    public Location currentLocation;
    public Image locationImage;
    public GameObject header;
    public GameObject body;

    public Text headerText;
    public Text bodyText;

    public GameEvent endPOIInteraction;

    // Start is called before the first frame update
    void Awake()
    {
       locationImage.sprite = currentLocation.LocationSprite;
       
        
        headerText.text = currentLocation.LocationName;
       
        bodyText.text = currentLocation.LocationDescription;
       
    }

    private void ResetCurrentLocation()
    {
        currentLocation.LocationName = "";
        currentLocation.LocationDescription = "";
        currentLocation.LocationSprite = null;
    }
    public void EndInteraction()
    {
        ResetCurrentLocation();
        endPOIInteraction.Raise();
       
    }

}
