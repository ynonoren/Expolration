using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestController : MonoBehaviour
{
    public Text displayText;
    public Button optionText;
    [HideInInspector]
    public RoomNavigation roomNavigation;
    [HideInInspector]
    public List<string> exitDescriptionInRoom=new List<string>();
    [HideInInspector]
    public List<string> interactionDescriptionsInRoom = new List<string>();

    List<Button> clones = new List<Button>();

    List<string> actionLog = new List<string>();

    public int X_START;
    public int Y_START;
    public int X_SPACE_BETWEEN_ITEM;
    public int NUMBER_OF_COLOMN;
    public int Y_SPACE_BETWEEN_ITEM;
    void Awake()
    {
        roomNavigation = GetComponent<RoomNavigation>();
    }

    public void DisplayLoggedText()
    {
        string logAsText = string.Join("\n",actionLog.ToArray());

        displayText.text = logAsText;
    }
    private void Start()
    {
        DisplayRoomText();
        DisplayLoggedText();
        DisplayRoomInteractions();
    }


    public void DisplayRoomText()
    {
        ClearCollectionsForNewRoom();
        UnpackRoom();

        string joinedInteractionDescriptions = string.Join("\n", exitDescriptionInRoom.ToArray());

        string combinedText = roomNavigation.currentRoom.description + "\n" + joinedInteractionDescriptions;

        LogStringWithReturn(combinedText);
    }
   

    public void DisplayRoomInteractions()
    {

       

        for (int i = 0; i < interactionDescriptionsInRoom.Count; i++)
        {
            clones.Add(Instantiate(optionText, Vector3.one, Quaternion.identity, transform));
            clones[i].GetComponent<RectTransform>().localPosition = GetPosition(i);
            clones[i].GetComponentInChildren<Text>().text = interactionDescriptionsInRoom[i];
        }
    }



    private void UnpackRoom()
    {

        roomNavigation.UnpackExitInRoom();
    }

    void ClearCollectionsForNewRoom()
    {
        interactionDescriptionsInRoom.Clear();
        exitDescriptionInRoom.Clear();
        roomNavigation.ClearExits();

        foreach(var clone in clones)
        {
            Destroy(clone);
        }
        clones.Clear();
    }



    public void LogStringWithReturn(string stringToAdd)
    {
        actionLog.Add(stringToAdd + "\n");
    }



    private Vector3 GetPosition(int i)
    {
        return new Vector3(X_START + (X_SPACE_BETWEEN_ITEM * (i % NUMBER_OF_COLOMN)), Y_START + (-Y_SPACE_BETWEEN_ITEM * (i / NUMBER_OF_COLOMN)), 0f);

    }

}
