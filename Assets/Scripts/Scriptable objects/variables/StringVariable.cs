

using UnityEngine;


[CreateAssetMenu(menuName = "Exploration/Variable/StringVariable")]
public class StringVariable : ScriptableObject
    {
        [SerializeField]
        [TextArea]
    private string value = "";

          
        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }



    }
