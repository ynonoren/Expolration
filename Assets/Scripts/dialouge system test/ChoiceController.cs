using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceController : MonoBehaviour
{
    public GameEvent converstionChangeEvent;
    public Choice choice;




    public void MakeChoise()
    {
        converstionChangeEvent.Raise();
    }

    public static ChoiceController AddChoiceButton(Button choiceButtonTemplate,Choice choise, int index)
    {
        int buttonSpacing = -44;

        Button button = Instantiate(choiceButtonTemplate);

        button.transform.SetParent(choiceButtonTemplate.transform.parent);
        button.transform.localScale = Vector3.one;
        button.transform.localScale = new Vector3(0, index * buttonSpacing, 0);
        button.name = "choice " + (index + 1);
        button.gameObject.SetActive(true);


        ChoiceController choiceController = button.GetComponent<ChoiceController>();
        choiceController.choice = choise;
        return choiceController;
    }



}
