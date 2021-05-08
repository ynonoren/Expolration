using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitRoomOption : MonoBehaviour
{


    public string optionText;
    private void Start()
    {
        optionText = GetComponentInChildren<Text>().text;
    }

    public void SendOptionData()
    {
        GetComponentInParent<RoomNavigation>().ChangeRooms(optionText);
        Destroy(gameObject);
    }

}
