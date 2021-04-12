using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingController : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

   public void EnterParking()
    {
        rb.isKinematic = true;
    }
    public void ExitParking()
    {
        rb.isKinematic = false;
    }
}
