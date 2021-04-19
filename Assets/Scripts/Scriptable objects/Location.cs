using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Exploration/Location")]
public class Location : ScriptableObject
{
    [SerializeField]
    private string locationName = "";

    public string LocationName
    {
        get { return locationName; }
        set { this.locationName = value; }
    }


    [SerializeField]
    [Multiline]
    private string locationDescription = "";

    public string LocationDescription

    {
        get { return locationDescription; }
        set { this.locationDescription = value; }
    }




    [SerializeField]
    private Sprite locationSprite;


    public Sprite LocationSprite

    {
        get { return locationSprite; }
        set { this.locationSprite = value; }
    }


}
