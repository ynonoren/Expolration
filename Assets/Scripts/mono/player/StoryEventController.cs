using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryEventController : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

   public void DisableCar()
    {
        rb.isKinematic = true;
    }
    public void EnableCar()
    {
        rb.isKinematic = false;
    }
}
