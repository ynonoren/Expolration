using System.Collections;
using System.Collections.Generic;

using UnityEngine;


    public class FuelManager : MonoBehaviour
    {
        public FloatVariable fuel;
        public FloatVariable fuelConsumptionRate;
        public bool refillFuel;
        public FloatReference startingFuel;
        public BoolVariable dayIsRunning;
    private void Start()
        {
       
        fuel.SetValue(startingFuel);
       
        }
    private void Update()
    {
        if (dayIsRunning.Value)
        {
            ConsumeFuel();
        }
    }
    public void ConsumeFuel()
        {

       
        if (fuel.Value <= 0f)
        {
            if (refillFuel)
            {
                fuel.SetValue(startingFuel);
                GetComponent<Rigidbody>().isKinematic = false;
            }
            else
            {
                GetComponent<Rigidbody>().isKinematic = true;
            }
         
         
        }
        else
        {
            fuel.ApplyChange(-fuelConsumptionRate.Value/100);
        }
        
       }
    }
