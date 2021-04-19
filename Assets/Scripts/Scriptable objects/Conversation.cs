using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct line
{
    public Location location;
    [TextArea(2, 5)]
    public string text;
}



[CreateAssetMenu(menuName = "Exploration/Conversation")]
public class Conversation : ScriptableObject
{

    public Location location;
    public line[] lines;

}
