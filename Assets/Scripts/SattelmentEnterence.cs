using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SattelmentEnterence : MonoBehaviour
{
    public Transform exitPoint;
    public GameEvent EnterSattelment;
    public GameEvent ExitSattelment;

    private void Update()
    {
        
            if (Input.GetKey(KeyCode.E))
            {

                ExitSattelment.Raise();
             

                Debug.Log("You have left the sattelment, day count is resumed.");
            }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {       
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            rb.MovePosition(exitPoint.transform.position);
            rb.MoveRotation(exitPoint.transform.rotation);
            EnterSattelment.Raise();
        }
    }

    

}
