using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;
    public bool steering;
    public bool Braking;
}

[RequireComponent (typeof(FuelManager))]
public class CarController : MonoBehaviour
{
    public List<AxleInfo> axleInfos;
    public FloatReference maxMotorTorque;
    public FloatReference maxSteeringAngle;
    public FloatReference brakeTorqe;
    private bool applyBrake=false;
    private bool toggleEngine=true;




    // finds the corresponding visual wheel
    // correctly applies the transform
    public void ApplyLocalPositionToVisuals(WheelCollider collider)
    {
        if (collider.transform.childCount == 0)
        {
            return;
        }

        Transform visualWheel = collider.transform.GetChild(0);

        Vector3 position;
        Quaternion rotation;
        collider.GetWorldPose(out position, out rotation);

        visualWheel.transform.position = position;
        visualWheel.transform.rotation = rotation;
    }

    public void FixedUpdate()
    {
        float motor;
        if (toggleEngine)
        { 
            motor = maxMotorTorque * Input.GetAxis("Vertical");
        }
        else
        {
            motor = 0;
        }

        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
        HandBrake();

        foreach (AxleInfo axleInfo in axleInfos)
        {
            if (axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if (axleInfo.motor && !applyBrake)
            {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;

            }
            if(axleInfo.Braking && applyBrake)
                {
                axleInfo.leftWheel.brakeTorque = brakeTorqe;
                axleInfo.rightWheel.brakeTorque = brakeTorqe;
                axleInfo.leftWheel.motorTorque = 0;
                axleInfo.rightWheel.motorTorque = 0;
            }
            else
            {
                axleInfo.leftWheel.brakeTorque = 0;
                axleInfo.rightWheel.brakeTorque = 0;
            }

         

            ApplyLocalPositionToVisuals(axleInfo.leftWheel);
            ApplyLocalPositionToVisuals(axleInfo.rightWheel);
        }
    }
    void HandBrake()
    {
        if (Input.GetKey(KeyCode.Space))
        {
               applyBrake = true;
        }
        else
        {
            applyBrake = false;
        }
    }


    public void CutEngine()
    {

        toggleEngine = false;

    }
    public void StartEngine()
    {
        toggleEngine = true;
    }
}