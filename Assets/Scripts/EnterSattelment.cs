using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterSattelment : MonoBehaviour
{
    public BoolVariable playerInSattelment;


    private void Update()
    {
        if (playerInSattelment.Value)
        {
            if (Input.GetKey(KeyCode.E))
            {


                playerInSattelment.SetValue(false);

                Debug.Log("You have left the sattelment, day count is resumed.");
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

           
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();

            rb.MovePosition(transform.position);
            rb.MoveRotation(transform.rotation);
            rb.velocity = Vector3.zero;
            playerInSattelment.SetValue(true);
          
            Debug.Log("You have Entered a sattelment, day count paused. /n" +
                "to leave sattelment press E.");

        }
    }
  

}
