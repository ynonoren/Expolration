using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoomNavigation : MonoBehaviour
{
    public Room currentRoom;


    Dictionary<string, Room> exitDictionary = new Dictionary<string, Room>();


    private QuestController controller;




    private void Awake()
    {
        controller = GetComponent<QuestController>();
    }

    public void UnpackExitInRoom()
    {
        for (int i = 0; i < currentRoom.exits.Length; i++)
        {
            exitDictionary.Add(currentRoom.exits[i].exitInteractionText, currentRoom.exits[i].valueRoom);
            controller.exitDescriptionInRoom.Add(currentRoom.exits[i].exitDescription);
            controller.interactionDescriptionsInRoom.Add(currentRoom.exits[i].exitInteractionText);
        }
    } 

   public void ChangeRooms(string exitName)
    {
       
        if (exitDictionary.ContainsKey(exitName))
        {
           
            currentRoom = exitDictionary[exitName];
            controller.LogStringWithReturn("You left the room.");
            controller.DisplayRoomText();
            controller.DisplayLoggedText();
            controller.DisplayRoomInteractions();
        }
    }

    public void ClearExits()
    {
        exitDictionary.Clear();
    }


}
