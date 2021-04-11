using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveHealth : MonoBehaviour
{
    public FloatReference HPBoost;
    public FloatVariable HP;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<FuelManager>())
        {
            HP.SetValue(50);
        }
    }

    
}
