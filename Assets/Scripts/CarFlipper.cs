using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFlipper : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Dot(transform.up, Vector3.down) > 0)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                rb.rotation=Quaternion.Euler(Vector3.up);
            }
        }
    }




}
