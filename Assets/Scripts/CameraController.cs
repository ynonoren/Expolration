using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float height = 10f;
    public float distance = 20f;
    public float angle = 45f;




    // Start is called before the first frame update
    void Start()
    {
        HandleCamera();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCamera();
    }
         void HandleCamera()
    {
        Vector3 worldPosition = (Vector3.forward * -distance) + (Vector3.up * height);

        Vector3 rotatedVector =Quaternion.AngleAxis(angle,Vector3.up) * worldPosition;

        Vector3 flatTargetPosition = target.position;

        flatTargetPosition.y = 0;

        Vector3 finalPosition = flatTargetPosition + rotatedVector;

        transform.position = finalPosition;
        transform.LookAt(flatTargetPosition);
    }





}
